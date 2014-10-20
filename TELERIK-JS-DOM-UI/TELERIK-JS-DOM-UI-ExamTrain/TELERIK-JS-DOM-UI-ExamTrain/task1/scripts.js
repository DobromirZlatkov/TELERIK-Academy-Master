function createCalendar(containerId, events) {
    var container = document.querySelector(containerId);
    var dayBox = document.createElement('div');
    var dayBoxTitle = document.createElement('strong');
    var dayBoxContent = document.createElement('div');
    dayBoxContent.innerHTML = '&nbsp';

    var daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
    var DAYS_IN_MONTH_COUNT = 30;

    var selectedBox = null;
    //styles

    dayBoxContent.className = 'day-content';
    dayBoxTitle.className = 'title-content';

    container.style.width = '1200px';

    dayBox.style.margin = '0';
    dayBox.style.border = '1px solid black';
    dayBox.style.display = 'inline-block';
    dayBox.style.width = '150px';
    dayBox.style.height = '150px';


    dayBoxTitle.style.display = 'block';
    dayBoxTitle.style.backgroundColor = 'lightgray';
    dayBoxTitle.style.borderBottom = '1px solid black';
    dayBoxTitle.style.textAlign = 'center';


    //append childs
    dayBox.appendChild(dayBoxTitle);
    dayBox.appendChild(dayBoxContent);



    function createMonthBoxes(events) {
        var dayBoxes = [];
        for (var i = 0; i < DAYS_IN_MONTH_COUNT; i++) {
            var dayOfWeek = daysOfWeek[i % daysOfWeek.length];
            dayBoxTitle.innerHTML = dayOfWeek + ' ' + (i + 1) + ' June 2014';
            dayBoxes.push(dayBox.cloneNode(true));
        }
        return dayBoxes;
    }

    function addCalendarEvents(boxes, events) {
        for (var i = 0; i < events.length; i++) {
            var event = events[i];
            var content = boxes[event.date - 1].querySelector('.day-content');
            content.innerHTML += event.hour + ' ' + event.title;
        }
    }


    function resetBoxesStyles(boxes) {
        for (var i = 0; i < boxes.length; i++) {
            boxes[i].style.backgroundColor = 'white';
        }
    }

    function onBoxMouseover(ev) {
        if (selectedBox !== this) {
            this.firstChild.style.backgroundColor = 'gray';
        }
        
    }

    function onBoxMouseout(ev) {
        if (selectedBox !== this) {
            this.firstChild.style.backgroundColor = 'lightgray';
        }
    }

    function onBoxClick(ev) {
        if (selectedBox) {
            selectedBox.firstChild.style.backgroundColor = 'lightgray';
        }

        if (selectedBox && selectedBox === this) {
            selectedBox = null;
        }
        else {
            this.firstChild.style.backgroundColor = 'red';
            selectedBox = this;
        }


    }


    var boxes = createMonthBoxes();
    addCalendarEvents(boxes, events);

    var docFragment = document.createDocumentFragment();

    for (var i = 0; i < boxes.length; i++) {
        docFragment.appendChild(boxes[i]);

        boxes[i].addEventListener('click', onBoxClick);
        boxes[i].addEventListener('mouseover', onBoxMouseover);
        boxes[i].addEventListener('mouseout', onBoxMouseout);
    }

    container.appendChild(docFragment);
}
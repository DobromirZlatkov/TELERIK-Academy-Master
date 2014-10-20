function createCalendar(container, events) {
    var container = document.querySelector(container),
        dayBox = document.createElement('div'),
        headBox = document.createElement('h4'),
        eventBox = document.createElement('div'),
        days = document.createDocumentFragment(),
        isSelected = null;

    var weekDays = ['Sun', 'Mon', 'Tue', 'Wed', 'Thi', 'Fri', 'Sat'];

    //set styles
    container.style.width = '1000px';

    dayBox.style.border = '1px solid black';
    dayBox.style.width = '140px';
    dayBox.style.height = '140px';
    dayBox.style.display = 'inline-block';
    dayBox.setAttribute('class', 'day-container');

  //  headBox.innerHTML = 'asd';
    headBox.style.borderBottom = '1px solid black';
    headBox.style.backgroundColor = 'lightgray';
    headBox.style.textAlign = 'center';
    headBox.style.margin = '0';

    eventBox.setAttribute('class', 'events-container');
    eventBox.style.float = 'left';

    dayBox.appendChild(headBox);
    dayBox.appendChild(eventBox);


    //clones day
    generateDays(dayBox);

    //add days to container
    container.appendChild(days);

    //append examEvents
    appendExamEvents(events);

    //add events
    var allDays = document.querySelectorAll('.day-container');
    for (var i = 0; i < allDays.length; i++) {
        allDays[i].addEventListener('click', onMouseClick);
        allDays[i].addEventListener('mouseover', onMouseover);
        allDays[i].addEventListener('mouseout', onMouseout);
    }




    function onMouseClick(ev) {
        
        if (isSelected) {
            isSelected.firstChild.style.backgroundColor = 'lightgray';
        }        
        if (isSelected === this) {
            isSelected = null;
        }
        else {
            this.firstChild.style.backgroundColor = 'white';
            isSelected = this;
        }
        
    }

    function onMouseover(ev) {
        if (isSelected !== this) {
            this.firstChild.style.backgroundColor = 'gray';
        }
    }

    function onMouseout(ev) {
        if (isSelected !== this) {
            this.firstChild.style.backgroundColor = 'lightgray';
        }
    }

    function appendExamEvents(events) {
        var dayContainers = document.querySelectorAll('.events-container');
        for (var i = 0; i < events.length; i++) {
            dayContainers[parseInt(events[i].date) - 1].innerHTML = events[i].hour + " " + events[i].title;
        }
    }

    function generateDays(dayBox) {
        for (var i = 0; i < 30; i++) {
            var currentDay = dayBox.cloneNode(true),
                dayHeaderInnerText = weekDays[i % 7] + ' ' + (i + 1) + ' June 2014';

            currentDay.firstChild.innerHTML = dayHeaderInnerText;

            days.appendChild(currentDay);
        }
    }
    
}
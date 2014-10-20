var events = [{
    title: 'JavaScript UI & DOM exam',
    date: 17,
    time: '10:00',
    duration: 360
},
   {
       title: 'C# KPK exam',
       date: 21,
       time: '12:30',
       duration: 660
   },
];
var selector = 'calendar';

function createCalendar(selector, events) {
    var wrapper = document.getElementById(selector),
        header = document.createElement('h1'),
        allDaysFragment = document.createDocumentFragment(),
        unOrderedList = document.createElement('ul'),
        startDayOfTheWeek = 6,
        liDictionary = [];

    header.textContent = 'The Calendar';

    wrapper.appendChild(header);
    
    

    for (var i = 0; i < 30; i++) {
        var list = document.createElement('li'),
            listHeader = document.createElement('h2');
            //isSelected = false;

        listHeader.textContent = selectDay(startDayOfTheWeek) + ' ' + (i + 1).toString() + ' June 2014';
        listHeader.style.backgroundColor = 'gray';
        listHeader.style.fontSize = '12px';
        listHeader.style.margin = '0';
        listHeader.style.padding = '0';
        listHeader.style.textAlign = 'center';
        listHeader.style.borderBottom = '1px solid black';
        list.appendChild(listHeader);
        list.style.display = 'inline-block';
        list.style.width = '100px';
        list.style.height = '100px';
        list.style.border = '1px solid black';
        list.style.margin = '0';
        list.style.padding = '0';
        //list.onmouseover = function () {
        //    if (!isSelected) {
        //        var h2InLiOnHoover = this.firstChild;
        //        h2InLiOnHoover.style.backgroundColor = 'white';
        //    }
        //};
        //list.onmouseout = function () { 
        //    if (!isSelected) {
        //        var h2InLiOnHoover = this.firstChild;
        //        h2InLiOnHoover.style.backgroundColor = 'gray';
        //    }      
        //}
        //list.onclick = function () {
        //    var h2InLiOnHoover = this.firstChild;
        //    h2InLiOnHoover.style.backgroundColor = 'red';
        //    isSelected = true;
        //}

        allDaysFragment.appendChild(list);
        startDayOfTheWeek++;
    }
    unOrderedList.appendChild(allDaysFragment);
    wrapper.appendChild(unOrderedList);
    
    unOrderedList.addEventListener('click', function (ev){
        if (document.getElementById('current')) {
            var current = document.getElementById('current');
            current.style.background = 'lightgray';
            current.addEventListener('mouseover', onMouseOver, false);
            current.addEventListener('mouseout', onMouseOut, false);
            current.id = '';
        }
        ev.target.id = 'current';
        ev.target.style.background = 'red';
        ev.target.removeEventListener('mouseover', onMouseOver, false);
        ev.target.removeEventListener('mouseout', onMouseOut, false);
    })

    

    //by given loop of numbers it generate string days of week
    function selectDay(number) {
        if (number > 6) {
            number %= 7;
        }
        switch (number) {
            case 0: return 'Mon';
            case 1: return 'Tue';
            case 2: return 'Wed';
            case 3: return 'Thur';
            case 4: return 'Fri';
            case 5: return 'Sat';
            case 6: return 'Sun';
            default: return 'unknown';
        }
    }
}

createCalendar(selector, events);
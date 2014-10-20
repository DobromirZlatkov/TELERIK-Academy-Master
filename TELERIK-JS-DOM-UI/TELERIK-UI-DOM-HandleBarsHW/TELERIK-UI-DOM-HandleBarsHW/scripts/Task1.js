(function () {

    var courses = [{
        id: 0,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 1,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 2,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 3,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 4,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 5,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 6,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 7,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }, {
        id: 8,
        name: 'Course introduction',
        firstDate: 'Wed 18:00,28-May-2014',
        secondDate: 'Thu 14:00, 29-May-2014'
    }];

    var templateSource = document.getElementById('lections-table-template').innerHTML;
    var template = Handlebars.compile(templateSource);
    var coursesHtml = template({ courses: courses });

    var container = document.getElementById("lections-table-container");
    container.innerHTML = coursesHtml;
}())
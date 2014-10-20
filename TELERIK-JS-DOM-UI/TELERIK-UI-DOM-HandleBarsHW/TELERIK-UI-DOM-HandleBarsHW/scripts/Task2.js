(function(){var items = [{
    value: 1,
    text: 'one'
}, {
    value: 2,
    text: 'two'
}, {
    value: 3,
    text: 'three'
}, {
    value: 4,
    text: 'four'
}, {
    value: 5,
    text: 'five'
}
];

    var templateSource = document.getElementById('post-template').innerHTML;
    var template = Handlebars.compile(templateSource);

    var selectOptionsHtml = template({ items: items });

    var container = document.getElementById('container');
    container.innerHTML += selectOptionsHtml;
}())
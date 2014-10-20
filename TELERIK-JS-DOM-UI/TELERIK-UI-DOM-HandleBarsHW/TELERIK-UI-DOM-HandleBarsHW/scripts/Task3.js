function makeListView(dataCollection) {
    if (!dataCollection) {
        throw new Error('dataCollection is not optional.');
    }

    var templateId = $(this).data('template');
    var template = $('#' + templateId).html();
    var templateCollection = Handlebars.compile(template);
    $(this).html(templateCollection(dataCollection));
    return $(this);
}

var books = {
    books: [
        { id: 1, title: 'JavaScript: The good parts', author: 'Douglas Crockford' },
        { id: 2, title: 'Secrets of the JavaScript Ninja', author: 'John Resig' },
        { id: 3, title: 'Core HTML5 Canvas: Graphics, Animation, and Game Development', author: 'David Geary' },
        { id: 4, title: 'JavaScript Patterns', author: 'Stoyan Stefanov' },
    ]
};

var students = {
    students: [
        { name: 'Minko Praznikov', mark: 6 },
        { name: 'Sofia Vergara', mark: 6 },
        { name: 'Kate Backinsale', mark: 5 },
        { name: 'Nikoleta Lozanova', mark: 3 },
        { name: 'Maria Sharapova', mark: 4 },
    ]
};

$(document).ready(function () {
    $.fn.listview = makeListView;
    $('#books-list').listview(books);
    $('#students-table').listview(students);
});
define([], function () {
    var Book = (function () {

        function Book(name, author) {
            this.name = name;
            this.author = author;
        }

        Book.prototype.toString = function () {
            return this.name + '__' + this.author;
        }

        return Book;
    }());
    return Book;
});

define([], function () {
    var Student = (function () {

        function Student(firstName, lastName, age, mark) {
            this.firstName = firstName || 'Ivan';
            this.lastName = lastName || 'Ivanov';
            this.age = age || 21;
            this.mark = mark || 2;
        }

        Student.prototype.toString = function () {
            return this.firstName + '__' + this.lastName + '__' + this.age + '__' + this.mark;
        }

        return Student;
    }());
    return Student;
});

define([], function () {
    var Course;
    Course = (function () {
        function Course(title, scoreFormula) {
            this.title = title;
            this.scoreFormula = scoreFormula;
            this.students = [];
        }

        function sortStudents(students, count, sortBy) {
            students.sort(function (first, second) { return second[sortBy] - first[sortBy] })
            return students.slice(0, count);
        }




        Course.prototype = {
            addStudent: function (student) {
                this.students.push(student);
                return this;
            },
            calculateResults: function () {
                var self = this;
                this.students.forEach(function (student) {
                    student.totalResult = self.scoreFormula(student);
                });
            },
            getTopStudentsByExam: function (count) {
                return sortStudents(this.students, count, 'exam');
            },
            getTopStudentsByTotalScore: function (count) {
                return sortStudents(this.students, count, 'totalResult');
            }
        };
        return Course;
    }())
    return Course;
})
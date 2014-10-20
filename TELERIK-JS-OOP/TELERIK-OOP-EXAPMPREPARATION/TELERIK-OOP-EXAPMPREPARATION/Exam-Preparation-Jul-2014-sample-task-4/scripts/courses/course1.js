define(['courses/student1'], function (Student) {
    var Course;
    Course = (function () {

        function getTopStudentsBy(sortBy, numberOfStudents) {
            if (this._studentsAndResults.length === 0) {
                this.calculateResults();
            }
            var i, sortedStudentsAndScores = [], len;
            for (i = 0, len = this._studentsAndResults.length; i < len; i += 1) {
                sortedStudentsAndScores.push(this._studentsAndResults[i]);
            }
            sortedStudentsAndScores.sort(sortBy);

            return sortedStudentsAndScores.slice(0, numberOfStudents);
        }

        function sortByTotalScore(a, b) {
            return b.result - a.result;
        }

        function sortByExam(a, b) {
            return b.student.exam - a.student.exam;
        }

        function addStudent(student) {
            if (!(student instanceof Student)) {
                throw {
                    massage: 'Courses can add only students'
                }
            }
            this._students.push(student);
        }

        function calculateResults() {
            var i, len, currentStudent, currentStudentResult;

            for (i = 0, len = this._students.length; i < len; i += 1) {
                currentStudent = this._students[i];
                currentStudentResult = this._formula(currentStudent);
                this._studentsAndResults.push({
                    student: currentStudent,
                    result: currentStudentResult
                })
            }
        }

        function getTopStudentsByTotalScore(numberOfStudents) {
            return getTopStudentsBy.call(this, sortByTotalScore, numberOfStudents);
        }

        function getTopStudentsByExam(numberOfStudents) {
            return getTopStudentsBy.call(this, sortByExam, numberOfStudents);
        }

        function Course(name, resultFormula) {
            this._name = name;
            this._formula = resultFormula;
            this._students = [];
            this._studentsAndResults = [];
        }

        Course.prototype = {
            addStudent: addStudent,
            calculateResults: calculateResults,
            getTopStudentsByTotalScore: getTopStudentsByTotalScore,
            getTopStudentsByExam: getTopStudentsByExam
        };

        return Course;
    })();
    return Course;
});
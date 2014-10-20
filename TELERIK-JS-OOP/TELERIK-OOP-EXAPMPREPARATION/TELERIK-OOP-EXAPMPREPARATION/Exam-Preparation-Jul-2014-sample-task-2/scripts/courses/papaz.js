define(['courses/student'],function (Student) {
    var Course;
    Course = (function () {

        function calculateTotalScoreForStudent(student) {
            return this._formula(student);
        }

        function returnSortedStudentsBy(sortBy, count) {
            if (!this._totalScores ||
                  this._totalScores.length !== this._students.length) {
                this.calculateResults();
            }
            var count = count || this._totalScores.length;
            var totalScores = this._totalScores.slice(0);
            totalScores.sort(sortBy);
            //to check map wtf; ?? ?A A?!?!
            return totalScores.map(function (student) {
                var studentToReturn = Object.create(student.student);
                studentToReturn.totalScore = student.totalScore;
                return studentToReturn;
            }).slice(0, count);

        }

        function sorteByExam(st1,st2) {
            return st2.student.exam - st1.student.exam;
        }

        function sorteByTotalScore(st1, st2) {
            return st2.totalScore - st1.totalScore;
        }

        function Course(name, formula) {
            this._name = name;
            this._formula = formula;
            this._students = [];
        }
     
        Course.prototype = {
            addStudent: function (student) {
                if (!(student instanceof Student)) {
                    throw {
                        massage: 'Not instance of Student'
                    }
                }
                this._students.push(student);
                return this;
            },
            calculateResults: function () {
                var i, len, student, studentTotalScore;
                this._totalScores = [];
                for (i = 0, len = this._students.length; i < len; i += 1) {
                    student = this._students[i];
                    studentTotalScore = calculateTotalScoreForStudent.call(this, student);
                    this._totalScores.push({
                        student: student,
                        totalScore: studentTotalScore
                    });
                }
                return this;
            },
            getTopStudentsByExam: function (count) {
                return returnSortedStudentsBy.call(this, sorteByExam, count);
            },
            getTopStudentsByTotalScore: function (count) {
                return returnSortedStudentsBy.call(this, sorteByTotalScore, count);

            }
        };
        return Course;
    })();
    return Course;
});
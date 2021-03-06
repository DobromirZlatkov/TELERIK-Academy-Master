(function () {
    require(['courses/course', 'courses/student'], function (Course, Student) {

        var jsCourseTotalScoreFormula = function (student) {
            return 65 * student.exam / 100 +
                   15 * student.homework / 5 +
                   20 * student.attendance / 4 +
                    0 * student.teamwork / 30 +
                    5 * student.bonus / 10;
        };
//
      //  var jsOopCourse = new Course('JavaScript OOP', jsCourseTotalScoreFormula);
        //add students like this
        for (var i = 0; i < 30; i++) {

            var student = new Student({
                name: 'Peter Petrov',
                exam: Math.random() * 100,
                homework: Math.random() * 4,
                attendance: Math.random() * 4,
                teamwork: Math.random() * 30,
                bonus: Math.random() * 5
            });
            console.log(student);
        }
        

        
       // jsOopCourse.calculateResults();
       // console.log(jsOopCourse._totalScores);
       // var topByExam = jsOopCourse.getTopStudentsByExam(2);
       // var topByTotalScore = jsOopCourse.getTopStudentsByTotalScore(7);

       // console.log(topByExam);

       // console.log(topByTotalScore);

    });
}());


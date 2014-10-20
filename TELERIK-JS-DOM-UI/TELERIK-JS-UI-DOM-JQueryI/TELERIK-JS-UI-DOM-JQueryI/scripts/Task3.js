/// <reference path="../bower_components/jquery/dist/jquery.js" />

(function () {
    var students = [{
        firstName: 'Ivan',
        lastName: 'Ivanov',
        grade: 3
    }, {
        firstName: 'Gosho',
        lastName: 'Peevski',
        grade: 4
    }, {
        firstName: 'Delqn',
        lastName: 'Peevski',
        grade: 0.1
    }, {
        firstName: 'Misho',
        lastName: 'Ivanov',
        grade: 5
    }, {
        firstName: 'Mihail',
        lastName: 'Mihov',
        grade: 6
    }
    ];
    var $container = $('#container');

    var $table = $('<table>').css('border','1px solid black').appendTo('<body>');
   
    var $tr = $('<tr><td></td><td></td><td></td></tr>');

    $table.html('<tr><th>First name</th><th>Last name</th><th>Grade</th></tr>');

    loadTableWithStudentsDate($tr, students, $table);

    $table.appendTo($container);
   
    function loadTableWithStudentsDate($tr, students, $table) {
        for (var i = 0; i < students.length; i++) {
            var $currentRow = $tr.clone();
            var $currentStudent = students[i];
            loadCurrentRowWithData($currentStudent, $currentRow);
            $table.append($currentRow);
        }
    }

    function loadCurrentRowWithData(currentStudent, currentRow) {
        currentRow.children().first().text(currentStudent.firstName);
        currentRow.children().first().next().text(currentStudent.lastName);
        currentRow.children().last().text(currentStudent.grade);
    }

}())
/// <reference path="../bower_components/jquery/dist/jquery.js" />
(function () {
    'use strict';
    require(['httpRequestModuleWithJquery'], function (httpRequest) {

        function visualizeStudents(data) {
            var list, i, len, student, jsonData, item;
            list = document.createElement('ul');
            jsonData = data;//JSON.parse(data) if not using Jquery module
            len = jsonData.count;

            for (i = 0; i < len; i += 1) {
                student = jsonData.students[i];
                item = document.createElement('li');
                item.innerHTML = "ID:" + student.id + ' <strong>' + student.name + '</strong> is in <strong>' + student.grade + 'th</strong> grade';
                list.appendChild(item);
            }
            document.getElementById('http-response').appendChild(list);
        }

        function visualizeError(err) {
            document.getElementById('http-response').innerHTML = "<div style='color:red;font-weight:bold'>Error</div>";
        }

        function makeGetRequest() {        
            document.getElementById('http-response').innerHTML = '';
            httpRequest.getJSON(url, headerOptions)
            .then(visualizeStudents, visualizeError);        
        }

        var url = "http://localhost:3000/students",
            headerOptions = {
                contentType: 'application/json',
                accept: 'application/json',
            },
            $container = $('#wrapper'),
            $studentNameHolder = $('#student-name'),
            $studentGradeHolder = $('#student-grade'),
            $studentIdToDeleteHolder = $('#student-id'),
            $addStudentBtn = $('#save-student'),
            $removeStudentBtn = $('#delete-student'),
            $showAllStudentsBtn = $('#show-students');

        $container.on('click', '#save-student', function () {
            var studentName = $studentNameHolder.val(),
                studentGrade = $studentGradeHolder.val(),                           
                student = {
                    name: studentName,
                    grade: studentGrade
                };
         //   console.log(isNaN(studentName) && (typeof studentName == 'string') && (studentName.search(/[^a-zA-Z]+/) == -1))
            if (isNaN(studentName) && (typeof studentName == 'string') && (studentName.search(/[^a-zA-Z]+/) == -1)) {
                if (!isNaN(studentGrade) && studentGrade <= 12 && studentGrade > 0) {
                    httpRequest.postJSON(url, student, headerOptions).then(makeGetRequest);
                    $studentNameHolder.val('');
                    $studentGradeHolder.val('');
                }
                else {
                    $('<span>').addClass('errorbox').html('Invalid student grade. Grade should be a number between 1 and 12').css('color', 'red').appendTo($container).fadeOut(3000)
                }
            }
            else {
                $('<span>').addClass('errorbox').html('Invalid student name. Name should consist only A-z and cannot be empty').css('color', 'red').appendTo($container).fadeOut(3000);
            }
           
        });

        $container.on('click', '#delete-student', function () {
            httpRequest.deleteJSON(url + '/' + $studentIdToDeleteHolder.val() + '/')
            .then(makeGetRequest);
            $studentIdToDeleteHolder.val('');
        })
    });
}());
/// <reference path="E:\Programing\TELERIK-JS-Applications\TELERIK-JS-APLICATIONS-HW1\TELERIK-JS-APLICATIONS-HW1\bower_components/underscore/underscore.js" />
/// <reference path="E:\Programing\TELERIK-JS-Applications\TELERIK-JS-APLICATIONS-HW1\TELERIK-JS-APLICATIONS-HW1\bower_components/require/bin/requirejs.js" />
/// <reference path="libs/underscore.js" />
/// <reference path="objects/Animal.js" />
/// <reference path="libs/jquery.min.js" />
(function () {
    require(['objects/Student', 'objects/Animal', 'objects/Book'], function (Student, Animal, Book) {
      
        var $container = $('#container'),
            $firstTaskButton = $('<button>').addClass('first-task').appendTo($container).text('First Task'),
            $secondTaskButton = $('<button>').addClass('second-task').appendTo($container).text('Second Task'),
            $thirdTaskButton = $('<button>').addClass('third-task').appendTo($container).text('Third Task'),
            $thirdTaskButton = $('<button>').addClass('fourth-task').appendTo($container).text('Fourth Task'),
            $thirdTaskButton = $('<button>').addClass('fifth-task').appendTo($container).text('Fifth Task'),
            $thirdTaskButton = $('<button>').addClass('sixth-task').appendTo($container).text('Sixth Task'),
            $thirdTaskButton = $('<button>').addClass('seventh-task').appendTo($container).text('Seventh Task'),
            $resultContainer = $('<p>').addClass('result-container').appendTo($container),
            $allStudentsContainer = $('<p>').addClass('allStudents-container').appendTo($container),
            students = [new Student('Vanko', 'Asen', 22, 212),
                        new Student('Asen', 'Ivanov', 45, 32),
                        new Student('Ivan', 'Asen', 22, 334),
                        new Student('Kaloqn', 'Asen', 21, 2),
                        new Student('Mihail', 'Shishman', 12),
                        new Student('Ivailo', 'SelskiqCar', 45, 1234),
                        new Student('Ivan', 'Sracimir', 25, 1234),
                        new Student('Ivan', 'Aleksandar', 66, 1234),
                        new Student('Han', 'Malamir', 33, 1234),
                        new Student('Simeon', 'Veliki', 45, 1234)],
            animals = [new Animal('mamal', 'tiger', 4),
                       new Animal('mamal', 'elephant', 4),
                       new Animal('mamal', 'human', 2),
                       new Animal('reptile', 'iguana', 4),
                       new Animal('insect', 'centipede ', 100),
                       new Animal('insect', 'grasshopper ', 4),
                       new Animal('bird', 'chicken', 2),
                       new Animal('insect', 'lobster', 6),
                       new Animal('insect', 'spider', 8),
            ],
            books = [new Book('SomeBookName', 'Pesho'),
                    new Book('SomeOtherBookName', 'Acho'),
                    new Book('SomeBookName', 'Pesho'),
                    new Book('CoolBook', 'Pesho'),
                    new Book('BadBook', 'Pesho'),
                    new Book('CookBook', 'Misho'),
                    new Book('NoNameBOok', 'Vesko'),
                    new Book('BookForJS', 'Pepi'),
                    new Book('IntroductionInJava', 'Acho'),
            ];

 

        $allStudentsContainer.html('STUDENTS: ' + JSON.stringify(students) + " <BR/><BR/> ANIMALS: " + JSON.stringify(animals));

        //firstTask
        $container.on('click', '.first-task', function () {
            var result = '';

            _.chain(students)
            .filter(function (student) {
                return student.firstName < student.lastName;
            })
            .sortBy("firstName")
            .reverse()
            .value()
            .map(function (student) {
                result += (student.firstName + " " + student.lastName) + ', ';
            });
            $container.find('.result-container').text('');
            $container.find('.result-container').text(result);
        });

        //secondTask
        $container.on('click', '.second-task', function () {

            var result = '';
            _.chain(students)
            .filter(function (student) {
                return student.age > 17 && student.age < 25;
            })
            .map(function (student) {
                result += (student.firstName + " " + student.lastName + " " + student.age) + ' ,';
            });

            $container.find('.result-container').text('');
            $container.find('.result-container').text(result);

        });

        //thirdTask
        $container.on('click', '.third-task', function () {

            var result = _.chain(students)
                        .sortBy('mark')
                        .last()
                        .value();

            $container.find('.result-container').text('');
            $container.find('.result-container').text(result);

        });

        //fourth
        $container.on('click', '.fourth-task', function () {
            var result = "Look at the console";
                        _.chain(animals)
                        .sortBy('numberOfLegs')
                        .groupBy('species')                  
                        .map(function (animalGroup) {
                            console.log(animalGroup);
                        });

            $container.find('.result-container').text('');
            $container.find('.result-container').text(result);

        });
        //fifth
        $container.on('click', '.fifth-task', function () {
            var result = 0;
            _.chain(animals)
            .each(function (animal) {
                result += animal.numberOfLegs;
            });

            $container.find('.result-container').text('');
            $container.find('.result-container').text("Total number of legs = " + result);

        });
        //sixt
        $container.on('click', '.sixth-task', function () {
            
            
            var result = _.groupBy(books, 'author');

            result = _.sortBy(result, function (g) {
                return -g.length;
            })

            $container.find('.result-container').text('');
            $container.find('.result-container').text(result[0][0].author);
        });
        //seventh
        $container.on('click', '.seventh-task', function () {


            var resultFirstName = _.countBy(students, function (person) { return person.firstName });
            var index = _.max(resultFirstName);
            resultFirstName = _.invert(resultFirstName);

            var resultLastName = _.countBy(students, function (person) { return person.lastName });
            var lastNameindex = _.max(resultLastName);
            resultLastName = _.invert(resultLastName);

            $container.find('.result-container').text('');
            $container.find('.result-container').html("Most commont first name: " + resultFirstName[index] + "<br/>" + "Most common last name :" + resultLastName[lastNameindex]);

        });

    });
}());
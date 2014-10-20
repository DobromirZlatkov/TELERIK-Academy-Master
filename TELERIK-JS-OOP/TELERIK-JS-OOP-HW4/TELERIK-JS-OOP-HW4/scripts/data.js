/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/require.js" />
/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/handlebars.js" />
/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/jquery.js" />

define(['jquery', 'handlebars'], function ($) {

    return $.fn.loadTemplate = function () {
        var people = [
          { id: 1, name: "Doncho Minkov", age: 18, avatarUrl: "images/doncho.jpg" },
          { id: 2, name: "Georgi Georgiev", age: 19, avatarUrl: "images/georgi-georgiev.jpg" },
          { id: 3, name: "Ivo Kenov", age: 19, avatarUrl: "images/ivaylo-kenov.jpg" },
          { id: 4, name: "Niki Kostov", age: 19, avatarUrl: "images/nikolay-kostov.jpg" }
        ],
            $container = $(this),
            templateCode = $("#lector-template"),
            templateHtml = templateCode.html(),
            compiledTemplate = Handlebars.compile(templateHtml),
            i,
            len = people.length;

        for (i = 0 ; i < len; i++) {
            $container.append(compiledTemplate(people[i]));
        }

        return $container;
    }  
})

 
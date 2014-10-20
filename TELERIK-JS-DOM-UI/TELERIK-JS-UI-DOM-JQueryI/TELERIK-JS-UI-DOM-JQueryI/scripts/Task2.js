/// <reference path="../bower_components/jquery/dist/jquery.js" />
(function () {
    var $container = $('#wrapper');
    var $middleElement = $container.find('#malcolm-in-the-middle');

    $container.on('click', '.before', function () {
        $("<div />").insertBefore($middleElement).css('background','green');
    });
    $container.on('click', '.after', function () {
        $("<div>").insertAfter('#malcolm-in-the-middle').css('background','blue');
    });
}())
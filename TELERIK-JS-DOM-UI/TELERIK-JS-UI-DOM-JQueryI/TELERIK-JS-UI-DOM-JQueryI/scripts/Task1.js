/// <reference path="../bower_components/jquery/dist/jquery.min.js" />
/// <reference path="../bower_components/jquery/dist/jquery.js" />

(function () {
    var $container = $('<div>').addClass('wrapper').appendTo('body');

    var $firstContentDivs = $('<div />').html('<h1>First container<h1>').addClass('content').appendTo($container);

    var $secondContentDivs = $('<div />').html('<h1>Second container<h1>').addClass('content').appendTo($container);

    var $thirdContentDivs = $('<div />').html('<h1>Third container<h1>').addClass('content').appendTo($container);

    var $fourthContentDivs = $('<div />').html('<h1>Fourth container<h1>').addClass('content').appendTo($container);

    var $leftButton = $('<button>').text('<').addClass('left-slide-button').appendTo($container);

    var $rigthButton = $('<button>').text('>').addClass('rigth-slide-button').appendTo($container);

    $container.find('.content').first().addClass('current');
    $container.find('.content').hide();
    $container.find('.current').show()
    ;


    $container.on('click', '.rigth-slide-button', function () {
        var $currentSlide = $('.current');
        console.log($currentSlide.index() == $currentSlide.siblings().length - 1);
        if ($currentSlide.index() == $currentSlide.siblings().length - 2) {
            $container.find('.content').first().addClass('current');
        }
        else {
            $currentSlide.next().addClass('current');
        }
        $currentSlide.removeClass('current');
        $currentSlide.hide();
        $container.find('.current').show();
    });

    $container.on('click', '.left-slide-button', function () {
        var $currentSlide = $('.current');
        
        if ($currentSlide.is(':first-child')) {
            $container.find('.content').last().addClass('current');
        }
        else {
            $currentSlide.prev().addClass('current');
        }
        
        $currentSlide.removeClass('current');
        $currentSlide.hide();
        $container.find('.current').show();
    });

    
}())

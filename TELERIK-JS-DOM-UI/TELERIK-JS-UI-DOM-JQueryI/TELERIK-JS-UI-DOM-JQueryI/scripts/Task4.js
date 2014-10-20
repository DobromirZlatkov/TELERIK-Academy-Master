/// <reference path="../bower_components/jquery/dist/jquery.min.js" />
(function () {
    $('body').on('change', '#background-changer', function () {
        var $color = $(this).val();
        console.log($(this));
        $('body').css('background', $color);
    })
}())
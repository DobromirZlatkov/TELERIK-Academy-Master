/// <reference path="jquery.min.js" />

$.fn.tabs = function () {
    $container = $(this);
    $container.addClass('tabs-container');

    $container.find('.tab-item-content').hide();

    $container.on('click', '.tab-item-title', function () {
        $selectedTitle = $(this);
        $container.find('.tab-item').removeClass('current');
        $container.find('.tab-item-content').hide();
        $selectedTitle.next().show();
        $selectedTitle.parent().addClass('current');
    })
};










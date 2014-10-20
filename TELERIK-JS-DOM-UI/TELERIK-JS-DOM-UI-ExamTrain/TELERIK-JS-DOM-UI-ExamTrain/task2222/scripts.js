/// <reference path="jquery.min.js" />

$.fn.tabs = function () {
    $container = $(this).addClass('tabs-container');
    $container.find('.tab-item-content').hide();

    $container.on('click', '.tab-item-title', function () {
        $selected = $(this);
        $container.find('.tab-item-content').hide();
        $selected.next().show();

        $container.find('.current').removeClass('current');
        $selected.parent().addClass('current');
   
    })
};

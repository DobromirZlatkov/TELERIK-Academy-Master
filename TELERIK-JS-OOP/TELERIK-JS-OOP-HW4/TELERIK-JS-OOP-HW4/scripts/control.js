/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/jquery.js" />
/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/require.js" />
define(['jquery'], function ($) {

    return $.fn.combobox = function () {

        var $container = $(this);

        $container.on('click', 'div', function () {
            var $this = $(this);
            $this.siblings().hide();
            $this.addClass('selected');
        });

        $container.on('click', '.selected', function () {
            var $this = $(this);
            $container.find('.selected').removeClass('selected');
            $this.parent().children().show();
        });
    }
})

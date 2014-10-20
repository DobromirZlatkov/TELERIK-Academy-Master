/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/handlebars.js" />
/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/jquery.js" />
/// <reference path="E:\Programing\TELERIK-JS-OOP\TELERIK-JS-OOP-HW4\TELERIK-JS-OOP-HW4\libs/require.js" />

(function () {
    require.config({
        paths: {
            'jquery': '../libs/jquery',
            'handlebars': '../libs/handlebars',
            'control': 'control',
            'data': 'data'
        }
    })

    require(['jquery', 'data', 'control'], function () {

        $('#lector-list').loadTemplate();
        $('#lector-list').combobox();
    })
}());
/// <reference path="libs/jquery.js" />
/// <reference path="libs/require.js" />
/// <reference path="libs/sammy.js" />

(function () {

    require.config({
        paths: {
            'jquery': 'libs/jquery',
            'sammy': 'libs/sammy',
            'qjs': 'libs/papaz',
            'httpRequest': 'app/httpRequest',
            'controller': 'app/controller',
            'validationController': 'app/validation-controller',
            'uiController': 'app/ui-controller'
        }

    })
    require(['jquery', 'controller', 'sammy'], function ($, Controller, Sammy) {

        var appController = new Controller('http://crowd-chat.herokuapp.com/posts');
        appController.setEventHandler();

        var app = Sammy('#wrapper', function () {
            this.get('#/login', function () {
                if (appController.isLoggedIn()) {
                    window.location = '#/chat';
                    return;
                }

                appController.loadLoginForm();
            });
            this.get('#/chat', function () {

                if (!appController.isLoggedIn()) {
                    window.location = '#/login';
                    return;
                }
            });

            appController.loadChatBox();
        });

        app.run('#/login');
    });

})();
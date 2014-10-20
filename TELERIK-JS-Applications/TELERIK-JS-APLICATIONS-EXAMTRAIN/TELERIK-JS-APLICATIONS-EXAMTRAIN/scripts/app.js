/// <reference path="libs/require.js" />
(function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery',
            'qjs': 'libs/q',
            'sammy': 'libs/sammy',
            'underscore': 'libs/underscore',
            'httpRequester': 'scripts/httpRequestModule',
            'dataController': 'scripts/data-handle-controller',
            'mainController': 'scripts/controller',       
        }
    })

    require(['jquery', 'qjs', 'sammy', 'underscore', 'httpRequester', 'mainController'], function ($, Q, sammy, _, HttpRequester, Controller) {

        var appController = new Controller('http://localhost:3000/post');
        appController.setEventHandler();

        var app = sammy('#wrapper', function () {
            this.get('#/login', function () {

                if (appController.isUserLoggedIn()) {
                    window.location = '#/chat';
                    return;
                }
                appController.loadLogInForm();
            });
            this.get('#/chat', function () {

                if (!appController.isUserLoggedIn()) {
                    console.log(appController.isLoggedIn())
                    window.location = '#/login';
                    return;
                }
                appController.loadChatBox();
            });

            
        });
        app.run('#/login');
    });
}())
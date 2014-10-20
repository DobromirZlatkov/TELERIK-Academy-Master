/// <reference path="../libs/jquery.js" />
define(['jquery', 'dataController', 'httpRequester', 'sammy'], function ($, DataController, HttpRequester, Sammy) {

    var Controller = (function () {

        var REFRESH_TIME = 4000;
        var MASSAGE_SHOW_COUNT = 20;

        function Controller(resourseUrl) {
            this.resourseUrl = resourseUrl;
        };

        function setUsernameToSessionStorage(username) {
            sessionStorage.setItem('username', username);
        };

        function getUserNameFromSessionStorage() {
            return sessionStorage.getItem('username');
        };

        function deleteUserNameFromSessionStorage() {
            sessionStorage.clear();
        };

        Controller.prototype = {
            loadLogInForm: function () {
                $('#wrapper').load('partials/logIn-template.html');
            },
            isUserLoggedIn: function () {
                return getUserNameFromSessionStorage() != null;
            },
            loadChatBox: function () {
                var self = this;
                $.when(
                    $.get('partials/chat-template.html', function (data) {
                        $('#wrapper').html(data);
                        $('.username-box').html(getUserNameFromSessionStorage());
                        self.updateChatBox();
                        setInterval(function () {
                            self.updateChatBox();
                        }, REFRESH_TIME);
                    }));
            },
            updateChatBox: function () {
                HttpRequester.getJSON(this.resourseUrl)
                .then(function (data) {

                    var chatBoxHtml = DataController.chatBoxRenderer(data, MASSAGE_SHOW_COUNT);              
                    $('#chat-box').html(chatBoxHtml);
                });
            },
            setEventHandler: function () {
                var self = this;
                var $container = $('#wrapper');

                $container.on('click', '#login-button', function () {
                    var $logInInput = $('#user-name-input'),
                        username = $logInInput.val();

                    setUsernameToSessionStorage(username);
                });

                $container.on('click', '#logout-btn', function () {
                    var exit = confirm('Are you syre you want to exit ?');
                    if (exit === true) {
                        deleteUserNameFromSessionStorage();
                        window.location = '#/login';
                    }
                });

                $container.on('click', '#send-massage-btn', function () {
                    var $massage = $('#message-input').val();
                    var $userName = getUserNameFromSessionStorage();
                    var jsonObjectToSend = {
                        user: $userName,
                        text: $massage
                    };

                    HttpRequester.postJSON(self.resourseUrl, jsonObjectToSend)
                    .then(function () {
                        $('#message-input').val('');
                        self.updateChatBox();
                    });
                });
            }

        }

        return Controller;
    }());
    return Controller;
})
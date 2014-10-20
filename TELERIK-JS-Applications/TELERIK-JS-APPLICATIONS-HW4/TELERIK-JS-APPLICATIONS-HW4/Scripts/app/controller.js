/// <reference path="../libs/jquery.js" />
/// <reference path="../libs/jquery.js" />
define(['jquery', 'uiController', 'validationController', 'httpRequest'], function ($, UI, ValidationController, HttpRequester) {

    var Controller = (function () {

        var Controller = function (resourseUrl) {
            this.resourseUrl = resourseUrl;
            this.refreshTime = 4000;
            this.showMessageCount = 50;
        };

        Controller.prototype.getUsername = function () {
            return sessionStorage.getItem('username');
        };

        Controller.prototype.setUsername = function (username) {
            sessionStorage.setItem('username', username);
        };

        Controller.prototype.deleteUsername = function () {
            sessionStorage.clear();
        };

        Controller.prototype.isLoggedIn = function () {
            return this.getUsername() != null;
        };

        Controller.prototype.loadChatBox = function () {
            var self = this;
            $.when(
                $.get('partials/chatPartial.html', function (data) {
                    $('#wrapper').html(data);
                    $('.username-box').html(self.getUsername());
                    self.updateChatBox();
                    setInterval(function () {
                        self.updateChatBox();
                    }, self.refreshTime);
                }));
        };

        Controller.prototype.updateChatBox = function () {
            var self = this;

            HttpRequester.getJSON(self.resourseUrl)
            .then(function (data) {
                var chatBoxHtml = UI.createChatBox(data, self.showMessageCount);
                $('#chatbox').html(chatBoxHtml);
            });
        };

        Controller.prototype.loadLoginForm = function () {
            $('#wrapper').load('partials/loginPartial.html');
        }

        Controller.prototype.setEventHandler = function () {
            var self = this;
            var $wrapper = $('#wrapper');
            $wrapper.on('click', '#login-btn', function () {

                var $logInInput = $('#login-name'),
                    username = $logInInput.val(),
                    isValidUsername = ValidationController.validateUserName(username);

                if (isValidUsername) {
                    self.setUsername(username);
                    $logInInput.removeClass('error-validation');
                    window.location = '#/chat';
                    location.reload();
                }
                else {
                    $logInInput.addClass('error-validation');
                }
            });

            $wrapper.on('click', '#exit-btn', function () {
                var exit = confirm('Are you sure you want to exit?');
                if (exit === true) {
                    self.deleteUsername();
                    window.location = '#/login';
                }
            });
            $wrapper.on('click', '#submitmsg', function () {
                var $messageInput = $('#usermsg'),
                    enteredMessage = $messageInput.val();
                postBy = self.getUsername();

                if (enteredMessage) {

                    HttpRequester.postJSON(self.resourseUrl, {
                        user: postBy,
                        text: enteredMessage
                    })
                    .then(function () {

                        $messageInput.val('');
                        var postHtml = UI.createMessage(postBy, enteredMessage);

                        $('#chatbox').prepend(postHtml);

                        $messageInput.removeClass('error-validation');
                    }, function () {
                        $messageInput.addClass('error-validation');
                    })
                }
                else {
                    $messageInput.addClass('error-validation');
                }
            })
        }
        return Controller;
    }());

    return Controller;
})
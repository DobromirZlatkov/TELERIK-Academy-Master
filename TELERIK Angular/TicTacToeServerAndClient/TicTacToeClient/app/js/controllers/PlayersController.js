'use strict'
app.controller('PlayersController', ['$scope', '$location', 'notifier', 'auth', 'gameData', 'identity', 'testService', function CreateGameCtr($scope, $cookies, notifier, auth, gameData, identity, testService) {

    (function () {
        gameData.getAllUsersScores()
            .then(function (data) {
                $scope.allUsersScores = data;
            })
    }());

    $scope.allUsersShown = false;
    $scope.allUsersShownText = "Show";
    $scope.showAndHideAllUsers = showAndHideAllUsers;

    function showAndHideAllUsers() {
        if ($scope.allUsersShown == false) {
            $scope.allUsersShown = true;
            $scope.allUsersShownText = "Hide";
        }
        else {
            $scope.allUsersShown = false;
            $scope.allUsersShownText = "Show";
        }
    };


}])
'use strict';
app.controller('PlayGameCtr', ['$scope', 'notifier', 'auth', 'gameData', 'testService' , '$location', function CreateGameCtr($scope, notifier, auth, gameData, testService, $location) {

    $scope.gameId = testService.gameId;

    $scope.getGameStatus = (function () {
        var gameParams = {
            GameId: $scope.gameId
        };

        gameData.getGameStatus(gameParams)
            .then(function (data) {
                $scope.gameStatus = data;
                $scope.Board = data.Board.split('');

            }, function (error) {
                $scope.gameStatus = error;
                $scope.Board = error;
            })
    }($scope.gameId));

    $scope.getGameStatus = getGameStatus;

    var timer = setInterval(getGameStatus, 2000);

    function getGameStatus() {

        if ($location.path().indexOf('/play-game') === -1) {
            clearInterval(timer);
            return;
        }

        var gameParams = {
            GameId: $scope.gameId
        };

        gameData.getGameStatus(gameParams)
            .then(function (data) {
                $scope.gameStatus = data;
                $scope.Board = data.Board.split('');
            }, function (error) {
                $scope.gameStatus = error;
                $scope.Board = error;
            });
    };

    $scope.playGame = function (gameId, row, col) {
        var request = {
            GameId: gameId,
            Row: row,
            Col: col
        };
        gameData.playGame(request)
            .then(function (data) {

                getGameStatus();
            },function(){
                console.log(data)
                if(data == "It's not your turn!"){
                    notifier.error("It's not your turn!");
                }
            })
    };


}]);
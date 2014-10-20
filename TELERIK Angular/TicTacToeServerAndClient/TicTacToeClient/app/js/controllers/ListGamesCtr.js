'use strict'
app.controller('ListGamesCtr', ['$scope', '$location', 'notifier', 'auth', 'gameData', 'identity', 'testService', function CreateGameCtr($scope, $cookies, notifier, auth, gameData, identity, testService) {

    $scope.isAuthenticated = identity.isAuthenticated();

    $scope.joinGame = function (gameId) {
        var game = {
            GameId: gameId
        }
        testService.gameId = gameId;
        gameData.joinGame(game)
            .then(function (data) {
                notifier.success('Game joined sucessfully!');
                $scope.gameId = data;
            }, function (error) {
                notifier.error(error);
            })
    };

//
//    (function(){
//        gameData.takeJoinedGames()
//            .then(function(data){
//                $scope.joinedGames = data;
//            })
//    }());
//
//    $scope.joinedGamesShown = false;
//    $scope.joinedGameShownText = "Show";
//    $scope.showAndHideJoinedGames = showAndHideJoinedGames;
//
//    function showAndHideJoinedGames(){
//        if($scope.joinedGamesShown == false){
//            $scope.joinedGamesShown = true;
//            $scope.joinedGameShownText = "Hide";
//        }
//        else {
//            $scope.joinedGamesShown = false;
//            $scope.joinedGameShownText = "Show";
//        }
//    };

//    (function(){
//        gameData.takeMyGames()
//            .then(function(data){
//                $scope.myGames = data;
//        })
//    }());
//
//    $scope.myGamesShown = false;
//    $scope.myGameShownText = "Show";
//    $scope.showAndHideMyGames = showAndHideMyGames;
//
//    function showAndHideMyGames(){
//        if($scope.myGamesShown == false){
//            $scope.myGamesShown = true;
//            $scope.myGameShownText = "Hide";
//        }
//        else {
//            $scope.myGamesShown = false;
//            $scope.myGameShownText = "Show";
//        }
//    };


    (function () {
        gameData.takeAvailableGames()
            .then(function (data) {
                $scope.availableGames = data;
            })
    }());

    $scope.availableGamesShown = false;
    $scope.availableGameShownText = "Show";
    $scope.showAndHideAvailableGames = showAndHideAvailableGames;


    function showAndHideAvailableGames() {
        if ($scope.availableGamesShown == false) {
            $scope.availableGamesShown = true;
            $scope.availableGameShownText = "Hide";
        }
        else {
            $scope.availableGamesShown = false;
            $scope.availableGameShownText = "Show";
        }
    };

}]);

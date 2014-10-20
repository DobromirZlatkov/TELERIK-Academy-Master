'use strict'
app.controller('CreateGameCtr', ['$scope', '$location', 'notifier', 'auth', 'gameData', 'identity', 'testService' , function CreateGameCtr($scope, $location, notifier, auth, gameData, identity, testService) {

    $scope.isAuthenticated = identity.isAuthenticated();

    if (auth.isAuthenticated() == true) {
        $scope.createGame = function (name) {
            var game = {
                name: name
            }

            gameData.create(game)
                .then(function (data) {
                    notifier.success('Game created sucessfully!');
                    $scope.gameId = data;
                    console.log(data)
                    testService.gameId = JSON.parse(data);
                }, function (error) {
                    notifier.error(error);
                })

        };
    }
}]);

'use strict'

app.factory('gameData', ['$http', '$q', 'authorization', 'baseServiceUrl', 'auth', '$location', function ($http, $q, authorization, baseServiceUrl, auth, $location) {
    var gamesApi = baseServiceUrl + '/api/games';
    var scoresApi = baseServiceUrl + '/api/Scores';

    return{
        create: function (game) {
            if (auth.isAuthenticated()) {
                var headers = authorization.getAuthorizationHeader();
                var deffered = $q.defer();

                $http.post(gamesApi + '/create', game, { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                        $location.path('/play-game');
                    }, function (response) {
                        deffered.reject(response);
                    });

                return deffered.promise;
            }
        },
        getAllUsersScores:function(){
            var deffered = $q.defer();

            $http.get(scoresApi + '/Top')
                .success(function (data) {
                    deffered.resolve(data);
                }, function (data) {
                    deffered.reject(data);
                });

            return deffered.promise;

        },
        takeMyGames: function () {
            if (auth.isAuthenticated()) {
                var deffered = $q.defer();

                var headers = authorization.getAuthorizationHeader();

                $http.get(gamesApi + '/mygames', { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                    }, function (data) {
                        deffered.reject(data);
                    });

                return deffered.promise;
            }
        },
        takeAvailableGames: function () {
            if (auth.isAuthenticated()) {
                var deffered = $q.defer();

                var headers = authorization.getAuthorizationHeader();

                $http.get(gamesApi + '/AvailableGames', { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                    }, function (data) {
                        deffered.reject(data);
                    });

                return deffered.promise;
            }
        },
        takeJoinedGames: function () {
            if (auth.isAuthenticated()) {
                var deffered = $q.defer();

                var headers = authorization.getAuthorizationHeader();

                $http.get(gamesApi + '/JoinedGames', { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                    }, function (data) {
                        deffered.reject(data);
                    });

                return deffered.promise;
            }
        },
        joinGame: function (game) {
            if (auth.isAuthenticated()) {
                var headers = authorization.getAuthorizationHeader();
                var deffered = $q.defer();

                $http.post(gamesApi + '/join', game, { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                        $location.path('/play-game');

                    }, function (response) {
                        deffered.reject(response);
                    });

                return deffered.promise;
            }
        },
        getGameStatus: function (gameParams) {
            if (auth.isAuthenticated()) {
                var headers = authorization.getAuthorizationHeader();
                var deffered = $q.defer();

                $http.post(gamesApi + '/Status', gameParams, { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                    }, function (response) {
                        deffered.reject(response);
                    });

                return deffered.promise;
            }
        },
        playGame: function (request) {
            if (auth.isAuthenticated()) {

                var headers = authorization.getAuthorizationHeader();

                var deffered = $q.defer();

                $http.post(gamesApi + '/Play', request, { headers: headers })
                    .success(function (data) {
                        deffered.resolve(data);
                    }, function (response) {
                        deffered.reject(response);
                    });

                return deffered.promise;
            }
        }
    }
}]);

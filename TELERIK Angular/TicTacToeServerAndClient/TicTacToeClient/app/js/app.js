'use strict';

var app = angular.module('myApp', ['ngRoute', 'ngResource', 'ngCookies']).
    config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/create-game', {
                templateUrl: 'views/partials/create-game.html',
                controller: 'CreateGameCtr'
            })
            .when('/all-games', {
                templateUrl: 'views/partials/all-games.html',
                controller: 'ListGamesCtr'
            })
            .when('/play-game', {
                templateUrl: 'views/partials/play-game.html',
                controller: 'PlayGameCtr'
            })
            .when('/players-rank', {
                templateUrl: 'views/partials/players-rank.html',
                controller: 'PlayersController'
            })
            .otherwise({ redirectTo: '/partial1' });
    }])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://localhost:4444');
'use strict';

musicApp.controller('PageController',
    function PageController($scope, author){
        $scope.author = author;
        $scope.date =
        {
            year:2014,
            month:3,
            day:26
        }
    }
)
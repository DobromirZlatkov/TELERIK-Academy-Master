'use strict'

musicApp.controller('ListArtistsController',
    function ListArtistsController($scope, artistData){
        $scope.artists = artistData.getAllArtists();
        console.log($scope.artists);
    })

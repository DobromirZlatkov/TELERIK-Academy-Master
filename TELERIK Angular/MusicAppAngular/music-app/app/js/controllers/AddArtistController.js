"use strict";

musicApp.controller('AddArtistController',
function AddArtistController($scope, artistData){

    $scope.saveArtist = function(artist, newArtistForm){
        if(newArtistForm.$valid)
        {
            console.log("saved");
            artistData.saveArtist(artist);
        }
        else{
            alert("invalid data")
        }
    };

    $scope.cancel = function(){
        alert('cancel');
    };
});

'use strict';
musicApp.controller('ArtistDetailsController',
function ArtistDetailsController($scope, $routeParams ,artistData){




    $scope.artist =  artistData.getArtist($routeParams.id);


    $scope.bandMembersShown = false;
    $scope.bandMembersShownText = "Show";
    $scope.showAndHideMembers = showAndHideMembers;

    $scope.bandMembers = "band-members";
    $scope.evenBandMembers = "even-band-members";

    $scope.customStyle = {
        fontWeight: 'bold'
    };

    $scope.bandRecodsShowText = 'View';
    $scope.bandRecordsShown = false;
    $scope.showAndHideRecords = showAndHideRecords;

    $scope.upVoteRating = upVoteRating;
    $scope.downVoteRating = downVoteRating;

    $scope.sort = 'rating';


    function showAndHideMembers(){
        if($scope.bandMembersShown == false){
            $scope.bandMembersShown = true;
            $scope.bandMembersShownText = "Hide";
        }
        else {
            $scope.bandMembersShown = false;
            $scope.bandMembersShownText = "Show";
        }
    }

    function showAndHideRecords(){
        if($scope.bandRecordsShown == false){
            $scope.bandRecordsShown = true;
            $scope.bandRecodsShowText = "Hide";
        }
        else {
            $scope.bandRecordsShown = false;
            $scope.bandRecodsShowText = "View";
        }
    }
    function upVoteRating(album){
        album.rating++;
    }

    function downVoteRating(album){
        if(album.rating >0) {
            album.rating--;
        }
    }
});
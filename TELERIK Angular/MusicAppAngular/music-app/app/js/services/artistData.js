'use strict';

musicApp.factory('artistData', function($resource) {

    var resource = $resource('/data/artist/:id.json', { id: '@id' });

        return {
        getArtist: function(id) {
            return resource.get({id: id})
        },
        saveArtist: function(artist) {
            window.alert("Saving is disabled for security reasons. Thank you for using Music Artists and have fun! :)")

        },
        getAllArtists: function() {
            return resource.query();
        }
    }

})
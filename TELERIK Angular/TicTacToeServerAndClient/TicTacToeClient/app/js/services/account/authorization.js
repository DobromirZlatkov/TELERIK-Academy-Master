'use strict';

app.factory('authorization', ['identity','notifier', function(identity,notifier) {
    return {
        getAuthorizationHeader: function() {

            var currentUser = identity.getCurrentUser();

            if(currentUser != undefined){
                return {
                    'Authorization': 'Bearer ' + currentUser['access_token']
                }
            }
            else{
                notifier.error('You are not loggedin')
            }

        }
    }
}]);
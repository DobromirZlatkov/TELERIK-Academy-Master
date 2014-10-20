define(function () {

    var Validation = (function () {
        function validateUserName(username) {
            console.log(1);
            var isValid = username && typeof username == 'string' && username.length >= 3 && username.length <= 25;
            return isValid;
        }

        return {
            validateUserName : validateUserName
        }
    }());

    return Validation;
})
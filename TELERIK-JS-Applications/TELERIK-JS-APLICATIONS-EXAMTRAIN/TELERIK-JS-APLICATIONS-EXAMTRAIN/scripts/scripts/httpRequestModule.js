define(['jquery', 'qjs'], function ($, Q) {
    var HttpRequester = (function () {

        var requestType = function (url, type, data) {

            var defered = Q.defer();
            $.ajax({
                url: url,
                type: type,
                data: data ? JSON.stringify(data) : '',
                contentType: 'application/json',
                timeout: 5000,
                success: function (data) {
                    defered.resolve(data);
                },
                error: function (err) {
                    defered.reject(err);
                }
            });

            return defered.promise;
        };

        var getJSON = function (url) {
            return requestType(url, "GET");
        }

        var postJSON = function (url, data) {
            return requestType(url, "POST", data);
        }

        return {
            getJSON: getJSON,
            postJSON: postJSON
        }
    })();

    return HttpRequester;
});
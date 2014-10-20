define(function () {
    var httpRequest = (function () {
        function getJSON(requestUrl, header) {
            var defered = Q.defer();
            $.ajax({
                beforeSend: function (xhrObj) {
                    xhrObj.setRequestHeader("Content-Type", JSON.stringify(header.contentType));
                    xhrObj.setRequestHeader("Accept", JSON.stringify(header.accept));
                },
                url: requestUrl,
                type: "GET",
                dataType: 'json',
                success: function (data) {
                    defered.resolve(data);
                },
                error: function (err) {
                    defered.reject(err);
                }
            });
            return defered.promise;
        };

        function postJSON(requestUrl, data, header) {
            var defered = Q.defer();
            $.ajax({
                beforeSend: function (xhrObj) {
                   // xhrObj.setRequestHeader("Content-Type", JSON.stringify(header.contentType));
                    xhrObj.setRequestHeader("Accept", JSON.stringify(header.accept));
                },
                url: requestUrl,
                type: 'POST',
                data: data,
                dataType: 'json',
                success: function (data) {
                    defered.resolve(data);
                },
                error: function (err) {
                    defered.reject(err);
                }
            });
            return defered.promise;
        }

        function deleteJSON(url, success, error) {
            var defered = Q.defer();
            $.ajax({
                url: url,
                type: 'POST',
                success:  function (data) {
                    defered.resolve(data);
                },
                error: function (err) {
                    defered.reject(err);
                },
                timeout: 5000,
                data: {_method: 'delete'}
            });
            return defered.promise;
        };
        

        return {
            getJSON: getJSON,
            postJSON: postJSON,
            deleteJSON: deleteJSON,
        }

    })();
    return httpRequest;
});
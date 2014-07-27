/// <reference path="../Libs/q.js" />
/// <reference path="../Libs/jquery-2.1.1.js" />
define(['Q', 'jquery'], function (Q, $) {

    var httpRequester = (function () {        

        function getJSON(url) {
            var deferred = Q.defer();

            $.ajax({
                url: url,
                type: "GET",
                contentType: "application/json",
                success: function (data) {
                    deferred.resolve(data);
                },
                error: function (err) {
                    deferred.reject(err);
                }
            });

            return deferred.promise;
        }

        function postJSON(url, data) {
            var deferred = Q.defer();

            $.ajax({
                url: url,
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(data),
                success: function (data) {
                    deferred.resolve(data);
                },
                error: function (err) {
                    deferred.reject(err);
                }
            });

            return deferred.promise;
        }

        return {
            getJSON: getJSON,
            postJSON:postJSON
        }

    }());
        
    return httpRequester;
});
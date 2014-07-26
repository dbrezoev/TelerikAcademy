/// <reference path="../Libs/q.js" />
/// <reference path="../Libs/jquery-2.1.1.js" />
/*

---------------TASK1--------------------

Create a module that exposes methods for performing 
HTTP requests by given URL and headers
getJSON and postJSON
Both methods should work with promises 
*/
var httpRequester = (function () {

    var url = 'DATA/persons.js';

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
            data: data,
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
        postJSON: postJSON
    }
}());
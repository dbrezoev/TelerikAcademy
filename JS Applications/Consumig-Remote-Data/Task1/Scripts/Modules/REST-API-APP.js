/// <reference path="../Libs/jquery-2.1.1.js" />
/// <reference path="../Libs/q.js" />
/*
 * 
Using the REST API at 'localhost:3000/students' create a web application for managing students
The REST API provides methods as follows:
POST creates a new student
GET returns all students
DELETE deletes a student by Id
You may extend the demo for jQuery.ajax()
 * 
 */
var manager = (function () {    

    function get(link) {
        var deferred = Q.defer();

        $.ajax({
            url: link,
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

    function add(link, data) {
        var deferred = Q.defer();

         $.ajax({    
            url: link,
            type: "POST",
            contentType: "application/json",
            data:JSON.stringify(data),
            success: function (data) {               
                deferred.resolve(data);
            },
            error: function (err) {
                deferred.reject(err);
            }
         });
        
        return deferred.promise;
    }

    function remove(link, data) {
        var deferred = Q.defer();
        $.ajax({
            url: link,
            type: "DELETE",
            contentType: "application/json",
            data:data,
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
        get:get,
        add: add,
        remove: remove,        
    }
}());
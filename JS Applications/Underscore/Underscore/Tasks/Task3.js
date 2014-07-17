/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 Write a function that by a given array of students finds the student with highest marks
 */
(function () {
    console.log('---Third TASK---');
    var students = [
        { firstName: 'Pesho', lastName: 'Goshov', age: 25 , mark: 7},
        { firstName: 'Boris', lastName: 'Todorv', age: 15 , mark: 8},
        { firstName: 'Vlado', lastName: 'Petrov', age: 18 , mark: 8},
        { firstName: 'Tisho', lastName: 'Dimov', age: 19  , mark: 6},
        { firstName: 'Rado', lastName: 'Petrov', age: 20  , mark: 9},
        { firstName: 'Rado', lastName: 'Stoikov', age: 30 , mark: 2},
        { firstName: 'Atanas', lastName: 'Stoikov', age: 7, mark: 3 },

    ];

    var result = _.max(students, function (student) {
        return student.mark;
    });
    console.log(result)
}());
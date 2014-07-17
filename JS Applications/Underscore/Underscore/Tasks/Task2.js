/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 Write function that finds the first name and last name of all 
 students with age between 18 and 24. Use Underscore.js
 */
(function () {
    console.log('---Second TASK---');
    var students = [
        { firstName: 'Pesho', lastName: 'Goshov', age: 25 },
        { firstName: 'Boris', lastName: 'Todorv', age: 15 },
        { firstName: 'Vlado', lastName: 'Petrov', age: 18 },
        { firstName: 'Tisho', lastName: 'Dimov', age: 19 },
        { firstName: 'Rado', lastName: 'Petrov', age: 20 },
        { firstName: 'Rado', lastName: 'Stoikov', age: 30 },
        { firstName: 'Atanas', lastName: 'Stoikov', age: 7 },

    ];

    var result = _.chain(students)
        .filter(function (student) {
            return student.age > 18 && student.age < 24;
        })
        .each(function (student) {
            console.log(student.firstName + ' ' + student.lastName)
        });
}());
/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 * Write a method that from a given array of students finds all
 *  students whose first name is before its last name alphabetically. 
 * Print the students in descending order by full name. Use Underscore.js
 */
(function () {
    console.log('---FIRST TASK---');
    var students = [
        { firstName: 'Pesho', lastName: 'Goshov' },
        { firstName: 'Boris', lastName: 'Todorv' },
        { firstName: 'Vlado', lastName: 'Petrov' },
        { firstName: 'Tisho', lastName: 'Dimov' },
        { firstName: 'Rado', lastName: 'Petrov' },
        { firstName: 'Rado', lastName: 'Stoikov' },
        { firstName: 'Atanas', lastName: 'Stoikov' },
        
    ];

    var result = _.chain(students)
        .filter(function (student) {
        return student.firstName < student.lastName;
        })
        .sortBy(function (student) {
        return student.firstName;
        })
        .reverse()
        .each(function (student) {
        console.log(student)
        });        
}());
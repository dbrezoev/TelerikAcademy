/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 By an array of people find the most common first and last name. Use underscore.
 */
(function () {
    console.log('---Seventh TASK---');
    var persons = [
        { firstName: 'Pesho', lastName: 'Goshov', age: 25, mark: 7 },
        { firstName: 'Boris', lastName: 'Todorv', age: 15, mark: 8 },
        { firstName: 'Vlado', lastName: 'Petrov', age: 18, mark: 8 },
        { firstName: 'Tisho', lastName: 'Dimov', age: 19, mark: 6 },
        { firstName: 'Rado', lastName: 'Petrov', age: 20, mark: 9 },
        { firstName: 'Rado', lastName: 'Stoikov', age: 30, mark: 2 },
        { firstName: 'Atanas', lastName: 'Stoikov', age: 7, mark: 3 },
    ];
    function getMostCommon(collection, name) {
        var fName = _.countBy(collection, function (p) {
            return p[name];
        });
        console.log(fName)        
        var mostCommonFirstNameIndex = _.max(fName);
        var inverted = _.invert(fName);
        console.log(inverted);
        return inverted[mostCommonFirstNameIndex];
    }

    var first = getMostCommon(persons, 'firstName');
    var last = getMostCommon(persons, 'lastName');
    console.log(first);
    console.log(last);    
}());
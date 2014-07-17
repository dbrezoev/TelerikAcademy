/// <reference path="Libs/underscore.js" />
(function () {
    'use strict';

    require.config({
        paths: {
            underscore: 'Libs/underscore',
        }
    });

    require(['Data/Animals', 'Data/Books', 'Data/Students', 'underscore'], function (animals, books, students) {

        //----------------------------------------------------------------------------------
        console.log('--Task 1--');
        console.log('Write a method that from a given array of students finds all students whose' +
        'first name is before its last name alphabetically. Print the students in descending order by full name.'+
        'Use Underscore.js');

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

        //----------------------------------------------------------------------------------
        console.log('--Task 2--');
        console.log('Write function that finds the first name and last name of all students with age between 18 and 24. Use Underscore.js');

        var result = _.chain(students)
        .filter(function (student) {
            return student.age >= 18 && student.age <= 24;
        })
        .each(function (student) {
            console.log(student.firstName + ' ' + student.lastName)
        });
        //----------------------------------------------------------------------------------
        console.log('--Task 3--');
        console.log('Write a function that by a given array of students finds the student with highest marks');
        var result = _.max(students, function (student) {
            return student.mark;
        });
        console.log(result);

        //----------------------------------------------------------------------------------
        console.log('--Task 4--');
        console.log('Write a function that by a given array of animals, groups them by species and sorts them by number of legs');
        var groups = _.groupBy(animals, 'spieces');
        console.log(groups);

        var ordered = _.sortBy(groups, function (arrayOfAnimals) {
            return arrayOfAnimals[0].legs;
        });

        console.log(ordered);
        //----------------------------------------------------------------------------------
        console.log('--Task 5--');
        console.log('By a given array of animals, find the total number of legs Each animal can have 2, 4, 6, 8 or 100 legs');
        var legsCount = _.reduce(animals, function (memo, animal) {
            return memo += animal.legs;
        }, 0);

        console.log(legsCount);
        //----------------------------------------------------------------------------------
        console.log('--Task 6--');
        console.log('By a given collection of books, find the most popular author (the author with the highest number of books)');
        var authors = _.countBy(books, function (book) {
            return book.author;
        });
        //console.log(authors);

        var popularIndex = _.max(authors);

        //console.log(popularIndex);
        var inverted = _.invert(authors);
        //console.log(inverted)
        console.log(inverted[popularIndex]);
        //----------------------------------------------------------------------------------
        console.log('--Task 7--');
        console.log('By an array of people find the most common first and last name. Use underscore.');
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

        var first = getMostCommon(students, 'firstName');
        var last = getMostCommon(students, 'lastName');
        console.log(first);
        console.log(last);
    });             
}());               
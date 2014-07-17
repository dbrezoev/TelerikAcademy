/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 Write a function that by a given array of animals, groups them by species and sorts them by number of legs
 */
(function () {
    console.log('---Fourth TASK---');
    var animals = [
        { spieces: 'cat', legs: 4, name: 'kitty' },
        { spieces: 'horse', legs: 4, name: 'horsy' },
        { spieces: 'fish', legs: 0, name: 'fishy' },
        { spieces: 'eagle', legs: 2, name: 'wtf' },
        { spieces: 'parrot', legs: 2, name: 'chocho' },
        { spieces: 'centipede', legs: 100, name: 'pesho' },
        { spieces: 'spider', legs: 8, name: 'spiderman' },
        { spieces: 'cat', legs: 4, name: 'kitty2' },
        { spieces: 'dog', legs: 4, name: 'doggy' },
        { spieces: 'cat', legs: 4, name: 'kitty3' },
        { spieces: 'fish', legs: 0, name: 'Kit' },
    ];    

    var groups = _.groupBy(animals, 'spieces');
    console.log(groups);

    var ordered = _.sortBy(groups, function (arrayOfAnimals) {
        return arrayOfAnimals[0].legs;
    });

    console.log(ordered);
    
}());
/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 By a given array of animals, find the total number of legs
Each animal can have 2, 4, 6, 8 or 100 legs
 */
(function () {
    console.log('---Fifth TASK---');
    var animals = [
        { spieces: 'cat', legs: 4, name: 'kitty' },
        { spieces: 'horse', legs: 4, name: 'horsy' },
        { spieces: 'eagle', legs: 2, name: 'wtf' },
        { spieces: 'parrot', legs: 2, name: 'chocho' },
        { spieces: 'centipede', legs: 100, name: 'pesho' },
        { spieces: 'spider', legs: 8, name: 'spiderman' },
        { spieces: 'spiderSix', legs: 6, name: 'spiderman6' },
        { spieces: 'spiderSix', legs: 6, name: 'spiderman66' },
        { spieces: 'cat', legs: 4, name: 'kitty2' },
        { spieces: 'dog', legs: 4, name: 'doggy' },
        { spieces: 'cat', legs: 4, name: 'kitty3' },
    ];

    var legsCount = _.reduce(animals, function (memo, animal) {
        return memo += animal.legs;
    }, 0);

    console.log(legsCount);
}());
/// <reference path="C:\Users\User\Documents\Visual Studio 2012\Projects\GITHUB_SVN\trunk\JS Applications\Underscore\Underscore\Scripts/underscore-min.js" />
/*
 By a given collection of books,
 find the most popular author (the author with the highest number of books)
 */
(function () {
    console.log('---Sixth TASK---');
    var books = [
        { name: 'The Great Gatsby', author: 'F. Scott Fitzgerald' },
        { name: 'The Grapes of Wrath', author: 'John Steinbeck' },
        { name: 'Nineteen Eighty-Four', author: 'George Orwell' },
        { name: 'The Pearl ', author: 'John Steinbeck' },
        { name: 'East of Eden', author: 'John Steinbeck' },
        { name: 'Animal Farm', author: 'George Orwell' },
    ];    

    var authors = _.countBy(books, function (book) {
        return book.author;
    });
    //console.log(authors);

    var popularIndex = _.max(authors);
    
    //console.log(popularIndex);
    var inverted = _.invert(authors);
    //console.log(inverted)
    console.log(inverted[popularIndex]);
    
    
}());
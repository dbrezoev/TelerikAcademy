/*Write a script that selects all the div nodes that are directly inside other div elements
Create a function using querySelectorAll()
Create a function using getElementsByTagName()
*/
(function () {
    function getDivs() {
        var divs = [];
        divs = document.getElementsByTagName('div');
        var result = [];
        var length = divs.length;
        for (var i = 0; i < length; i++) {
            if (divs[i].parentNode instanceof HTMLDivElement) {
                result.push(divs[i]);
            }
        }

        return result;
    }

    function getDivsQuery() {
        var divs = [];
        divs = document.querySelectorAll('div > div');

        return divs;
    }

    var divs = getDivs();
    console.log(divs.length);
    for (var i = 0; i < divs.length; i++) {
        console.log(divs[i].className);
    }
}());
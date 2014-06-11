/*
Create a function that gets the value of <input type="text"> ands prints its value to the console
*/
(function () {

    function getValue() {
        var input = document.querySelector('input');
        var content = input.value;
        console.log(content);
    }

    var submitElement = document.querySelector('a');
    submitElement.addEventListener("click", getValue, false);
}());
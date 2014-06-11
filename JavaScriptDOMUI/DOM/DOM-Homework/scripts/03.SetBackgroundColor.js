/*
Crеate a function that gets the value of <input type="color"> and sets the background of the body to this value
*/

(function () {
    function getColor() {
        var input = document.getElementById('color');
        var color = input.value;
        document.body.style.backgroundColor = color;
    }

    var submitElement = document.querySelector('a');
    submitElement.addEventListener("click", getColor, false);
}());
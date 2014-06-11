(function () {

    function onClickButton() {
        var input1 = document.getElementsByTagName('input')[0];
        var input2 = document.getElementsByTagName('input')[1];

        var color1 = input1.value;
        var color2 = input2.value;

        var textarea = document.getElementsByTagName('textarea')[0];
        textarea.style.color = color1;
        textarea.style.backgroundColor = color2;
    }

    var link = document.getElementsByTagName('a')[0];
    link.addEventListener('click', onClickButton, false);

}());
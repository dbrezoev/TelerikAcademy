(function () {
    function onBtnClicked() {
        var text = $('textarea').val();
        var color1 = $('#first').val();
        var color2 = $('#second').val();
        $('textarea').css({ color: color1, 'background-color': color2 });
    }
    $('#btn').on('click', onBtnClicked)
}());
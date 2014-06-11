(function () {
    $('img.pic').hide();
    var photos = $('img.pic');
    var index = 0;
    var first = photos.get(index);
    $(first).show();

    setInterval(function () {
        $(photos).hide();
        index += 1;
        if (index === photos.length) {
            index = 0;
        }
        var visible = photos.get(index);
        $(visible).show();
    }, 5000);

    $('#right').on('click', function () {
        index++;
        if (index === photos.length) {
            index = 0;
        }
        $('img.pic').hide();
        var curr = $('img.pic').get(index);
        $(curr).show();
    });

    $('#left').on('click', function () {
        index--;
        if (index === -1) {
            index = photos.length - 1;
        }
        $('img.pic').hide();
        var curr = $('img.pic').get(index);
        $(curr).show();
    });
}());
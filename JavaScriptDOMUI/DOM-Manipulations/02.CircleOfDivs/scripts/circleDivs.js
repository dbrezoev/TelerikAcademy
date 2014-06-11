(function () {

    function makeDivStyle(div) {
        div.style.position = 'absolute';
        div.style.width = 30 + 'px';
        div.style.height = 30 + 'px';
        div.style.borderRadius = 30 + 'px';
        div.style.borderWidth = 2 + 'px';
        //div.style.top = top + 'px';
        //div.style.left = left + 'px';
        div.style.borderStyle = 'solid';

    }

    function moveDiv(div, top, left) {
        div.style.top = top + 'px';
        div.style.left = left + 'px';
    }
    var radius = 100;
    var centerX = 200;
    var centerY = 200;

    var angle = 10;
    var points = [];
    for (var i = 0; i < 5; i++) {

        var div = document.createElement('div');
        var px = centerY;
        var py = centerX;
        makeDivStyle(div);
        moveDiv(div, px, py);
        document.body.appendChild(div);
        points.push(div);
    }

    setInterval(function () {

        for (var i = 0; i < points.length; i++) {
            var px = centerX + radius * Math.cos(angle);
            var py = centerX + radius * Math.sin(angle);

            moveDiv(points[i], px, py);
            angle += 5;
        }

    }, 100);

}());
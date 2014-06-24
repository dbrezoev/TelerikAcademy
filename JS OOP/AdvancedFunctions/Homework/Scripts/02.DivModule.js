var movingShapes = (function () {

    var RECTAGNLE_TOP = 135,
        RECTAGNLE_LEFT = 535,
        RECTANGLE_WIDTH = 400,
        RECTANGLE_HEIGHT = 220,
        CIRCLE_TOP = 150,
        CIRCLE_LEFT = 200,
        DIV_WIDTH = 30,
        DIV_HEIGHT = 30,
        divsInRectangle = [],
        divsInCircle = [];

    var initialDiv = document.createElement('div');

    function moveInCircle() {
        makeDivShiny(initialDiv);
        var div = initialDiv.cloneNode(true);      
        document.body.appendChild(div);
        
        var angle = 0;
        var radius = 100;
        var center = {
            x: CIRCLE_LEFT + CIRCLE_LEFT / 2,
            y: CIRCLE_TOP + CIRCLE_TOP / 2,
        }
        div.style.left = center.x + radius * Math.cos(angle) + 'px';
        div.style.top = center.y + radius * Math.sin(angle) + 'px';
        
        setInterval(function () {
            var newPosX = center.x + radius * Math.cos(angle) + 'px';
            var newPosY = center.y + radius * Math.sin(angle) + 'px';
            angle += 0.1;
            div.style.left = newPosX;
            div.style.top = newPosY;
        },100);

    }

    function moveInRectangle() {
        makeDivShiny(initialDiv);
        var div = initialDiv.cloneNode(true);
        div.style.top = RECTAGNLE_TOP + 'px';
        div.style.left = RECTAGNLE_LEFT + 'px';
        document.body.appendChild(div);

        //remove 'px' in the end
        var left = div.style.left.substring(0, div.style.left.length - 2);
        var top = div.style.top.substring(0, div.style.top.length - 2);

        //convert to numbers
        left = left | 0;
        top = top | 0;
        
        setInterval(function () {

            if (top === RECTAGNLE_TOP) {
                left += 5;
            }
            if (left === RECTAGNLE_LEFT + RECTANGLE_WIDTH) {
                top += 5;
            }
            if (top === RECTAGNLE_TOP + RECTANGLE_HEIGHT) {
                left -= 5;
            }
            if (left === RECTAGNLE_LEFT) {
                top -= 5;
            }
            
            div.style.left = left + 'px';
            div.style.top = top + 'px';

        }, 100);

    }

    function makeDivShiny(div) {
        div.innerHTML = 'div';
        div.style.color = getRandomColor();
        div.style.border = '1px';
        div.style.width = DIV_WIDTH + 'px';
        div.style.height = DIV_HEIGHT + 'px';
        div.style.borderColor = getRandomColor();
        div.style.borderStyle = 'solid';
        div.style.borderColor = getRandomColor();
        div.style.borderRadius = 20 + 'px';
        div.style.position = 'absolute';
        div.style.backgroundColor = getRandomColor();

        function getRandomColor() {
            var red = (Math.random() * 256) | 0;
            var green = (Math.random() * 256) | 0;
            var blue = (Math.random() * 256) | 0;
            return "rgb(" + red + "," + green + "," + blue + ")";
        }
    }

    function add(shape) {
        if (shape === 'rect') {
            moveInRectangle();
        }
        else if (shape === 'ellipse') {
            moveInCircle();
        }
    }

    return {
        add: add,
    }
}());
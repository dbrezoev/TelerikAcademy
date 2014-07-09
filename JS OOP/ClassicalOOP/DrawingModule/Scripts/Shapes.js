var drawingModule = (function () {
    var canvas = document.getElementById('canvas');
    var ctx = canvas.getContext('2d');

    function drawCircle(centerX, centerY, radius) {
        ctx.beginPath();        
        ctx.arc(centerX, centerY, radius, 0, Math.PI * 2, false);
        ctx.stroke();
    }

    function drawLine(x1, y1, x2, y2) {
        ctx.moveTo(x1, y1);
        ctx.lineTo(x2, y2);
        ctx.stroke();
    }

    function drawRect(x, y, width, height) {
        ctx.moveTo(x, y);
        ctx.strokeRect(x, y, width, height);
    } 
   
    return {
        draw :{
            circle: drawCircle,
            line: drawLine,
            rect: drawRect,           
        }
    }
}());
    
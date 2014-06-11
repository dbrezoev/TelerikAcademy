(function () {

    var canvas = document.getElementsByTagName('canvas')[0],
        ctx = canvas.getContext('2d'),
        direction = {
            x: 'right',
            y:'down',
        }
        ball = new Ball(50, 50, 5, 5, direction),
        directions = {
            'left': -1,
            'right': +1,
            'up': -1,
            'down': +1
        };

    function Ball(x, y, radius, speed, direction) {
        this.x = x;
        this.y = y;
        this.radius = radius;
        this.speed = speed;
        this.direction = direction;
    }

    Ball.prototype.draw = function (ctx) {        
        ctx.beginPath();
        ctx.arc(this.x, this.y, this.radius, 0, Math.PI * 2, false);
        ctx.fillStyle = 'red';
        ctx.fill();
        ctx.stroke();
    };

    Ball.prototype.move = function () {
        this.x += this.speed * directions[this.direction.x];
        this.y += this.speed * directions[this.direction.y];
    };

    Ball.prototype.bounce = function (maxX, maxY) {
        if (this.x < 0) {
            this.direction.x = 'right';
        }
        if (this.x > maxX) {
            this.direction.x = 'left';
        }

        if (this.y < 0) {
            this.direction.y = 'down';
        }
        if (this.y > maxY) {
            this.direction.y = 'up';
        }

    }

    function animationFrame() {
        ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
        ball.bounce(ctx.canvas.width, ctx.canvas.height);
        ball.move();        
        ball.draw(ctx);              
        requestAnimationFrame(animationFrame);
    }

    requestAnimationFrame(animationFrame);
}());
(function () {
    
    var canvas = document.getElementsByTagName('canvas')[0];
    var ctx = canvas.getContext('2d');

    var score = document.getElementsByTagName('div')[0];
    
    var points = 0;
    function Snake(x, y, size, speed) {
        this.x = x;
        this.y = y;
        this.size = size;
        this.tailParts = [new Part(this.x - 1*this.size, this.y, this.size),
                            new Part(this.x - 2 * this.size, this.y, this.size),
                            new Part(this.x - 3 * this.size, this.y, this.size)];
        this.direction = 'right';
        this.speed = speed;
        this.isAlive = true;        
    }

    Snake.prototype = {
        move: function () {           
            if (this.direction === 'right') {                               
                for (var i = this.tailParts.length - 1; i >= 1; i--) {
                    this.tailParts[i].x = this.tailParts[i - 1].x;
                    this.tailParts[i].y = this.tailParts[i - 1].y;
                }
                this.tailParts[0].x += this.speed + this.size;
            }
            else if (this.direction === 'left') {
                for (var i = this.tailParts.length - 1; i >= 1; i--) {
                    this.tailParts[i].x = this.tailParts[i - 1].x;
                    this.tailParts[i].y = this.tailParts[i - 1].y;
                }
                this.tailParts[0].x -= this.speed + this.size;
            }
            else if (this.direction === 'up') {
                for (var i = this.tailParts.length - 1; i >= 1; i--) {
                    this.tailParts[i].x = this.tailParts[i - 1].x;
                    this.tailParts[i].y = this.tailParts[i - 1].y;
                }
                this.tailParts[0].y -= this.speed + this.size;
            }
            else if (this.direction === 'down') {
                for (var i = this.tailParts.length - 1; i >= 1; i--) {
                    this.tailParts[i].x = this.tailParts[i - 1].x;
                    this.tailParts[i].y = this.tailParts[i - 1].y;
                }
                this.tailParts[0].y += this.speed + this.size;
            }
        },
        draw: function () {
            if (this.isAlive) {
                for (var i = 0; i < this.tailParts.length; i++) {
                    var currentPart = this.tailParts[i];
                    currentPart.draw();
                }
            }
            else {               
                ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
                ctx.font = "40px Georgia";
                ctx.fillText("Game over!", canvas.width / 2 - 40, canvas.height / 2);
                ctx.font = "40px Georgia";
                ctx.fillText("Your score: " + points, canvas.width / 2 - 140, canvas.height / 2+50);
            }
            
        },
        grow: function () {
            var lastIndex = snake.tailParts.length - 1;
            var newPart = new Part(snake.tailParts[lastIndex].x, snake.tailParts[lastIndex].y, snake.size);
            snake.tailParts.push(newPart);
        }        
    };

    function Part(x, y, size) {
        this.x = x;
        this.y = y;
        this.size = size;   
    }

    Part.prototype = {
        draw: function () {
            ctx = canvas.getContext('2d');
            ctx.fillStyle = 'green';
            ctx.fillRect(this.x, this.y, this.size, this.size);
            ctx.strokeRect(this.x, this.y, this.size, this.size);
        },        
    }

    function Food(x, y, size) {
        this.x = x;
        this.y = y;
        this.size = size;
        this.isAlive = true;
    }

    Food.prototype = {
        draw: function () {
            ctx.fillStyle = 'red';
            ctx.fillRect(this.x, this.y, this.size, this.size);
        },
        update: function () {
            if (!this.isAlive) {
                var foodNewCoordinateX = getRandomNumber(0, canvas.width);
                var foodNewCoordinateY = getRandomNumber(0, canvas.height);
                this.x = foodNewCoordinateX;
                this.y = foodNewCoordinateY;
            }            
        }
    }

    function getRandomNumber(min, max) {
        return Math.floor(Math.random() * (max - min) + min);
    }

    function handleUserControl() {
        document.onkeydown = function (event) {
            if (!event) {
                event = window.event;
            }
            if (event.keyCode === 37) {
                if (snake.direction === 'right') {
                    return;
                }
                snake.direction = 'left';
            }
            else if (event.keyCode === 38) {
                if (snake.direction === 'down') {
                    return;
                }
                snake.direction = 'up';
            }
            else if (event.keyCode === 39) {
                if (snake.direction === 'left') {
                    return;
                }
                snake.direction = 'right';
            }
            else if (event.keyCode === 40) {
                if (snake.direction === 'up') {
                    return;
                }
                snake.direction = 'down';
            }
        }
    }
    
    function controlGame() {
        if (snake.tailParts[0].x < food.x + food.size && snake.tailParts[0].x + snake.size > food.x &&
                 snake.tailParts[0].y < food.y + food.size && snake.tailParts[0].y + snake.size > food.y) {
            food.isAlive = false;
            points++;           
            snake.grow();
        }        
        score.innerHTML = 'Score: ' + points;
        food.update();
        food.isAlive = true;
    }
    function detectCollision() {
        var headX = snake.tailParts[0].x;
        var headY = snake.tailParts[0].y;
        if (headX < 0 || headX > canvas.width) {
            snake.isAlive = false;
        }
        if (headY < 0 || headY > canvas.height) {
            snake.isAlive = false;
        }
        for (var i = 1; i < snake.tailParts.length; i++) {
            var currentPart = snake.tailParts[i];
            if (headX === currentPart.x && headY === currentPart.y) {
                snake.isAlive = false;
            }
        }       
    }

    var snake = new Snake(100, 100, 15, 1);
    var foodX = getRandomNumber(0, canvas.width - 15);
    var foodY = getRandomNumber(0,canvas.width - 15);
    var food = new Food(foodX, foodY, snake.size/2);    
       
    function animationFrame() {
        ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);                
        snake.draw();
        snake.move();
        food.draw();
        handleUserControl();
        controlGame();
        detectCollision();        
        //requestAnimationFrame(animationFrame);
    }

    var gameRun = setInterval(animationFrame,150);
}());
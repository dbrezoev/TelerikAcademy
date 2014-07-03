define(['Snake/Game','Snake/GameObjects'], function (Game ,GameObjects) {
    var Renderer = (function () {
        
        function drawPart(canvas, part, color) {
            var ctx,
                color;
            color = color || 'green';
            ctx = canvas.getContext('2d');
            ctx.fillStyle = color;
            ctx.fillRect(part.x, part.y, part.size, part.size);
            ctx.strokeRect(part.x, part.y, part.size, part.size);
        }

        function drawSnake(canvas, snake) {
            var i,
                currentPart;

            if (snake.isAlive) {
                for (i = 0; i < snake.tailParts.length; i++) {
                    currentPart = snake.tailParts[i];
                    drawPart(canvas, currentPart, 'green');
                }
            }
        }

        function drawFood(canvas, food, color) {
            var ctx;
            ctx = canvas.getContext('2d');
            ctx.fillStyle = color || 'red';
            ctx.fillRect(food.x, food.y, food.size, food.size);
        }

        function CanvasRenderer(canvas) {
            if (canvas instanceof HTMLCanvasElement) {
                this.canvas = canvas;
            }
            else if (typeof canvas === 'String' || typeof canvas === 'string') {
                this.canvas = document.querySelector(canvas);
            }
        }

        CanvasRenderer.prototype = {
            draw: function (obj) {
                if (obj instanceof GameObjects.Snake) {
                    drawSnake(this.canvas, obj);
                }
                else if (obj instanceof GameObjects.Food) {
                    drawFood(this.canvas, obj);
                }
            },
            drawGameOver: function(){
                var ctx,
                finalPoints;
                ctx = this.canvas.getContext('2d');
                finalPoints = document.getElementById('score').innerHTML;
                ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
                ctx.font = "40px Georgia";
                ctx.fillText("Game over!", this.canvas.width / 2 - 40, this.canvas.height / 2);
                ctx.font = "40px Georgia";
                ctx.fillText("Your " + finalPoints, this.canvas.width / 2 - 140, this.canvas.height / 2 + 50);
            },
            clear: function () {
                var ctx,
                    width,
                    height;
                ctx = this.canvas.getContext('2d');
                width = this.canvas.width;
                height = this.canvas.height;
                ctx.clearRect(0, 0, width, height);
            }
        }

        return {
            getCanvas: function (canvas) {
                return new CanvasRenderer(canvas);
            }
        }

    }());
    return Renderer;
});
define([], function(){
var GameObjects = (function () {

    function getRandomNumber(min, max) {
        return Math.floor(Math.random() * (max - min) + min);
    }

    var Part = (function () {
        function Part(x, y, size) {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        return Part;
    }());

    var Snake = (function () {
        function Snake(x, y, size, step) {
            Part.call(this, x, y, size);
            this.direction = 'right';
            this.isAlive = true;
            this.step = step;
            this.tailParts = [new Part(this.x - 1 * this.size, this.y, this.size),
                                new Part(this.x - 2 * this.size, this.y, this.size),
                                new Part(this.x - 3 * this.size, this.y, this.size)];

        }

        Snake.prototype = {
            move: function () {
                if (this.direction === 'right') {
                    for (var i = this.tailParts.length - 1; i >= 1; i--) {
                        this.tailParts[i].x = this.tailParts[i - 1].x;
                        this.tailParts[i].y = this.tailParts[i - 1].y;
                    }
                    this.tailParts[0].x += this.step + this.size;
                }
                else if (this.direction === 'left') {
                    for (var i = this.tailParts.length - 1; i >= 1; i--) {
                        this.tailParts[i].x = this.tailParts[i - 1].x;
                        this.tailParts[i].y = this.tailParts[i - 1].y;
                    }
                    this.tailParts[0].x -= this.step + this.size;
                }
                else if (this.direction === 'up') {
                    for (var i = this.tailParts.length - 1; i >= 1; i--) {
                        this.tailParts[i].x = this.tailParts[i - 1].x;
                        this.tailParts[i].y = this.tailParts[i - 1].y;
                    }
                    this.tailParts[0].y -= this.step + this.size;
                }
                else if (this.direction === 'down') {
                    for (var i = this.tailParts.length - 1; i >= 1; i--) {
                        this.tailParts[i].x = this.tailParts[i - 1].x;
                        this.tailParts[i].y = this.tailParts[i - 1].y;
                    }
                    this.tailParts[0].y += this.step + this.size;
                }
            },
            grow: function () {
                var lastIndex = this.tailParts.length - 1;
                var newPart = new Part(this.tailParts[lastIndex].x, this.tailParts[lastIndex].y, this.size);
                this.tailParts.push(newPart);

            }
        }

        return Snake;
    }());

    var Food = (function () {
        function Food(x, y, size, color) {            
            Part.call(this, x, y, size);
            this.color = color || 'green';
            this.isAlive = true;
        }

        Food.prototype = {
            update: function (maxX, maxY) {
                if (!this.isAlive) {
                    var foodNewCoordinateX = getRandomNumber(0, maxX);
                    var foodNewCoordinateY = getRandomNumber(0, maxY);
                    this.x = foodNewCoordinateX;
                    this.y = foodNewCoordinateY;
                }
            }
        }

        return Food;

    }());

    return {
        Snake: Snake,
        Food: Food,
    }

}());

return GameObjects;

});
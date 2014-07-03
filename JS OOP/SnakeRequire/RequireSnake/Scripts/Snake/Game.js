define(['Snake/Renderer', 'Snake/GameObjects'], function(Renderer, GameObjects){
var Game = (function () {

    var renderer,
        canvas,
        snake,
        food,
        foodX,
        foodY,
        points,
        score,
        INITIAL_SNAKE_X,
        INITIAL_SNAKE_Y,
        SNAKE_SIZE,
        SNAKE_STEP,
        SNAKE_SPEED,
        FOOD_SIZE,
        FOOD_COLOR,
        CANVAS_WIDTH,
        CANVAS_HEIGHT,
        RIGHT_ARROW,
        LEFT_ARROW,
        DOWN_ARROW,
        UP_ARROW,
        gameRun,
        topPlayers,
        playersArray;

    canvas = document.getElementById('the-canvas');
    renderer = Renderer.getCanvas(canvas);
    points = 0;
    score = document.getElementsByTagName('div')[0];
    INITIAL_SNAKE_X = 100;
    INITIAL_SNAKE_Y = 100;
    SNAKE_STEP = 1;
    SNAKE_SIZE = 10;
    SNAKE_SPEED = 70;
    snake = new GameObjects.Snake(INITIAL_SNAKE_X, INITIAL_SNAKE_Y, SNAKE_SIZE, SNAKE_STEP);
    foodX = getRandomNumber(0, canvas.width);
    foodY = getRandomNumber(0, canvas.height);
    FOOD_SIZE = SNAKE_SIZE / 2;
    FOOD_COLOR = 'red';
    food = new GameObjects.Food(foodX, foodY, FOOD_SIZE, FOOD_COLOR);
    CANVAS_WIDTH = canvas.width;
    CANVAS_HEIGHT = canvas.height;
    LEFT_ARROW = 37;
    UP_ARROW = 38;
    DOWN_ARROW = 40;
    RIGHT_ARROW = 39;
    topPlayers = document.getElementById('top');
    playersArray = [];

    function handleUserControl() {
        document.onkeydown = function (event) {
            if (!event) {
                event = window.event;
            }
            if (event.keyCode === LEFT_ARROW) {
                if (snake.direction === 'right') {
                    return;
                }
                snake.direction = 'left';
            }
            else if (event.keyCode === UP_ARROW) {
                if (snake.direction === 'down') {
                    return;
                }
                snake.direction = 'up';
            }
            else if (event.keyCode === RIGHT_ARROW) {
                if (snake.direction === 'left') {
                    return;
                }
                snake.direction = 'right';
            }
            else if (event.keyCode === DOWN_ARROW) {
                if (snake.direction === 'up') {
                    return;
                }
                snake.direction = 'down';
            }
        }
    }

    function detectCollision() {
        var headX = snake.tailParts[0].x;
        var headY = snake.tailParts[0].y;
        if (headX < 0 || headX >= canvas.width) {
            snake.isAlive = false;
        }
        if (headY < 0 || headY >= canvas.height) {
            snake.isAlive = false;
        }
        for (var i = 1; i < snake.tailParts.length; i++) {
            var currentPart = snake.tailParts[i];
            if (headX === currentPart.x && headY === currentPart.y) {
                snake.isAlive = false;
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
        food.update(CANVAS_WIDTH, CANVAS_HEIGHT);
        food.isAlive = true;
    }

    function recordPoints() {
        var name,
            i,
            currentRow,
                row;

        name = prompt('Please provide your nickname');
        if (name === null) {
            name = 'unknown';
        }        
        if (localStorage.getItem(name) === null) {
            localStorage.setItem(name, points);           
        }
        else {
            
            if (points > localStorage.getItem(name)) {
                localStorage.setItem(name, points);
            }
        }

        for (i = 0; i < localStorage.length; i++) {
            playersArray.push({
                name: localStorage.key(i),
                points: localStorage.getItem(localStorage.key(i)) | 0,
            })
        }

        playersArray.sort(function (a, b) {
            return b.points - a.points;
        })
        console.log(playersArray)
        for (i = 0; i < 10 || playersArray.length; i++) {
            currentRow = i + 1;
            row = currentRow + '. ' + playersArray[i].name + ' ' + playersArray[i].points + 'pts' + '<br>';
            topPlayers.innerHTML += row;
        }
    }

    function stopGame() {
        clearInterval(gameRun);
        renderer.drawGameOver(canvas);

        setTimeout(function () {
            recordPoints();
        },2000)
        
    }
    function animationFrame() {
        if (snake.isAlive) {
            renderer.clear();
            renderer.draw(snake);
            snake.move();
            renderer.draw(food);
            handleUserControl();
            controlGame();
            detectCollision();
        }
        else {            
            stopGame();
        }
    }
    function getRandomNumber(min, max) {
        return Math.floor(Math.random() * (max - min) + min);
    }
   
    function Game() {
    }

    Game.prototype = {
        start: function () {
             gameRun = setInterval(animationFrame, SNAKE_SPEED);
        },
        stop: function () {
            clearInterval(animationFrame);
        },
        points: points
    }

    return Game;
    
}());

return Game;
});
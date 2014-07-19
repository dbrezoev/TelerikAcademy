/// <reference path="jquery-2.1.1.min.js" />
(function () {
    'use strict';

    var MAX_DIGITS = 4;
    var sheep = 0;
    var rams = 0;
    var rounds = 0;
    var secretNumber = generateSecretNumber();
    console.log(secretNumber);
    var inputValue;
    var getUserNameMessage = 'Please provide your nickname.';
    var players = [];

    $('#submit').on('click', function () {
        $('#rules').fadeOut(200);
        inputValue = $('#user-input').val().toString();

        if (!validateValue(inputValue)) {
            $('#content').append($('<p>').html('Wrong input'));
            var link = $('<a>').attr({href: '#', id: 'rules-link'}).html(' See rules');
            $('#content p').append(link);
            $('#rules-link').on('click', function () {
                alert(4)
            })
        } else {
            var userNumber = inputValue.toString();            
            checkSheepAndRams(inputValue);
            $('#content').append($('<p>').html(inputValue + ' You have ' + sheep + ' SHEEP and ' + rams + ' RAMS!'));

            rounds++;

            if (rams === MAX_DIGITS) {
                $('#content').append($('<p>').html('You revealed the mistery for ' + rounds + 'rounds.'));
                saveHighscore(rounds);
                renderHighscoreTable();
            }
            sheep = 0;
            rams = 0;
        }  
    });

    $('#gave-up').on('click', function () {
        saveHighscore(rounds);
        $('#content').append($('<p>').html('You gave up after ' + rounds + 'rounds. The secret number is [' + secretNumber + '].'));
        renderHighscoreTable();
    });

    function generateSecretNumber() {
        var digits = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
        var secretNumber = '';
        var i = 0;

        while (secretNumber.toString().length !== MAX_DIGITS) {
            var index = Math.floor(Math.random() * (9 - 0 + 1) + 0);
            if (digits[index] === 0 && i === 0) {
                i--;
                continue;
            }

            if (digits[index] !== 'x') {
                secretNumber += digits[index];
                digits[index] = 'x'; //marked as used
                i--;
            }
            i++;
        }
                
        return secretNumber.toString();
    }

    function validateValue(value) {
        if (value.length !== MAX_DIGITS) {
            return false;
        }

        if (isNaN(value)) {
            return false;
        }

        if (value[0] === '0') {
            return false;
        }

        //check for duplicated numbers in user input
        var count = {};
        for (var i = 0; i < value.length; i++) {
            var currentNumber = value[i];
            if (!count[currentNumber]) {
                count[currentNumber] = 0;
            }
            count[currentNumber]++;
        }

        for (var prop in count) {
            if(count[prop] != 1){
                return false;
            }
        }

        return true;
    }

    function checkSheepAndRams(number) {
        var secretNumberCopy = secretNumber;
        var userInputCopy = number;

        for (var i = 0; i < secretNumberCopy.length; i++) {
            if (userInputCopy[i] === secretNumberCopy[i]) {
                rams++;
                userInputCopy[i] = '*';
                secretNumberCopy[i] = '@';
            }
        }

        for (var i = 0; i < userInputCopy.length; i++) {
            for (var k = 0; k < secretNumberCopy.length; k++) {
                if (secretNumberCopy[k] === userInputCopy[i]) {
                    sheep++;
                    userInputCopy[i] = '*';
                    secretNumberCopy[i] = '@';
                }
            }
        }

        sheep -= rams;
    }

    function saveHighscore(rounds) {
        rounds = rounds | 0;
        var userName = prompt(getUserNameMessage);
        if (userName === undefined || userName === null) {
            return;
        }
        if (!localStorage[userName]) {
            localStorage.setItem(userName, rounds);
        }
        else {
            if (localStorage[userName] > rounds) {
                localStorage.setItem(userName, rounds);
            }
        }
    }

    function renderHighscoreTable() {
        for (var i = 0; i < localStorage.length; i++) {
            players.push({
                name: localStorage.key(i),
                rounds: localStorage[localStorage.key(i)]
            });
        }

        players = sort(players);

        for (var i = 0; i < players.length; i++) {
            $('#highscore').append($('<p>').html(i+1 + '. ' + players[i].name + ' ' + players[i].rounds + ' rounds.'))
        }
    }

    function sort(players) {
        return players.sort(function (first, second) {
            return first.rounds - second.rounds;
        });
    }
}());
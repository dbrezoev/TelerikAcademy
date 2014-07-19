/// <reference path="jquery-2.1.1.min.js" />
(function () {
    'use strict';
    var MAX_DIGITS,
        sheep,
        rams,
        rounds,
        secretNumber,
        inputValue,
        getUserNameMessage,
        players;

    MAX_DIGITS = 4;
    sheep = 0;
    rams = 0;
    rounds = 0;
    secretNumber = generateSecretNumber();    
    inputValue;
    getUserNameMessage = 'Please provide your nickname.';
    players = [];

    $('#submit').on('click', function () {
        var userNumber;

        inputValue = $('#user-input').val().toString();

        if (!validateValue(inputValue)) {
            $('#content').append($('<p>').html('Wrong input'));                       
        } else {
            userNumber = inputValue.toString();            
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
        var digits,
            secretNumber,
            i,
            index;

        digits = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
        secretNumber = '';
        i = 0;

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
        var i,
            currentNumber,
            prop;

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
        for (i = 0; i < value.length; i++) {
            currentNumber = value[i];
            if (!count[currentNumber]) {
                count[currentNumber] = 0;
            }
            count[currentNumber]++;
        }

        for (prop in count) {
            if(count[prop] != 1){
                return false;
            }
        }

        return true;
    }

    function checkSheepAndRams(number) {
        var secretNumberCopy,
            userInputCopy,
            i,
            k;

        secretNumberCopy = secretNumber;
        userInputCopy = number;

        for (i = 0; i < secretNumberCopy.length; i++) {
            if (userInputCopy[i] === secretNumberCopy[i]) {
                rams++;
                userInputCopy[i] = '*';
                secretNumberCopy[i] = '@';
            }
        }

        for ( i = 0; i < userInputCopy.length; i++) {
            for (k = 0; k < secretNumberCopy.length; k++) {
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
        var userName;

        rounds = rounds | 0;
        userName = prompt(getUserNameMessage);
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
        var i;

        for (i = 0; i < localStorage.length; i++) {
            players.push({
                name: localStorage.key(i),
                rounds: localStorage[localStorage.key(i)]
            });
        }

        players = sort(players);

        for (i = 0; i < players.length; i++) {
            $('#highscore').append($('<p>').html(i+1 + '. ' + players[i].name + ' ' + players[i].rounds + ' rounds.'))
        }
    }

    function sort(players) {
        return players.sort(function (first, second) {
            return first.rounds - second.rounds;
        });
    }
}());
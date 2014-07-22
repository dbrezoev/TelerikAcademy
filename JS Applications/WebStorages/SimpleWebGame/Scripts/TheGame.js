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
console.log(secretNumber);	
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

    var clicked = false;
    $('#gave-up').on('click', function () {
        if (clicked === false) {
            $('#content').append($('<p>').html('You gave up after ' + rounds + 'rounds. The secret number is [' + secretNumber + '].'));
            renderHighscoreTable();
        }
        else {
            return
        }
        clicked = true;
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
        var secretNumberArr = [],
            userInputArr = [],
            i,
            k;
		for(var i = 0; i < secretNumber.length; i++){
			secretNumberArr.push(secretNumber[i]);
		}
		
		for(var i = 0; i < number.length; i++){
			userInputArr.push(number[i]);
		}        

        for (var z = 0; z < secretNumberArr.length; z++) {
            if (userInputArr[z] === secretNumberArr[z]) {
                rams++;
                userInputArr[z] = '*';
                secretNumberArr[z] = '@';
            }
        }

        for ( i = 0; i < userInputArr.length; i++) {
            for (k = 0; k < secretNumberArr.length; k++) {
                if (secretNumberArr[k] === userInputArr[i]) {
                    sheep++;
                    userInputArr[i] = '*';
                    secretNumberArr[i] = '@';
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
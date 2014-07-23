/// <reference path="settings.js" />
define(['Modules/settings', 'Modules/numberGenerator',
    'Modules/validator', 'Modules/highscore', 'jquery'], function (settings, numberGenerator, validator, highScore) {
    'use strict'
    var game = (function () {

        var sheep = 0,
        rams = 0,
        rounds = 0,
        secretNumber,
        inputValue,        
        players;

        function run() {
            var maxDigits = settings.getDigitsCount();

            secretNumber = numberGenerator.getNumber(maxDigits);

            console.log(secretNumber);//easier to see and test it
       
            $('#submit').on('click', function () {
                var userNumber;

                inputValue = $('#user-input').val().toString();

                if (!validator.validateUserInput(maxDigits, inputValue)) {
                    $('#content').append($('<p>').html('Wrong input'));
                }
                else {
                    userNumber = inputValue.toString();
                    var result = validator.checkSheepAndRams(secretNumber, inputValue);
                    sheep = result[0];
                    rams = result[1];
                    $('#content').append($('<p>').html(inputValue + ' You have ' + sheep + ' SHEEP and ' + rams + ' RAMS!'));

                    rounds++;

                    if (rams === maxDigits) {
                        $('#content').append($('<p>').html('You revealed the secret number for ' + rounds + 'rounds.'));
                        highScore.save(rounds);
                        highScore.render();
                        $('#highscore').show();
                    }
                    sheep = 0;
                    rams = 0;
                }
            });
           
            $('#gave-up').one('click', function () {

                $('#content').append($('<p>')
                    .html('You gave up after ' + rounds + 'rounds. The secret number is [' + secretNumber + '].'));

                highScore.render();
                $('#highscore').show();
            });
        }

        return {
            run:run
        }
    }());

    return game;
})
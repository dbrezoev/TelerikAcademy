define([], function () {
    'use strict'
    var numberGenerator = (function () {
        
       // var maxDigits;

        function getRandomNumber(min, max) {
            return Math.floor(Math.random() * (max - min + 1) + min);
        }

        function generateSecretNumber(max) {
            var digits,
                secretNumber,
                i,
                maxDigits,
                index;

            digits = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
            secretNumber = '';
            i = 0;

            while (secretNumber.toString().length !== max) {
                var index = getRandomNumber(0, 9);
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

        return {
            getNumber: function (max) {
                return generateSecretNumber(max);
            }
        }

    }());

    return numberGenerator;
})
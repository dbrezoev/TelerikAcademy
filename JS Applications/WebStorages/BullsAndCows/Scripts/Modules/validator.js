define([], function () {
    'use strict'

    var validator = (function () {

        function validateValue(max, value) {
            var i,
                currentNumber,
                maxDigits,
                prop;

            if (value.length !== max) {
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
                if (count[prop] != 1) {
                    return false;
                }
            }

            return true;
        }
        
        function checkSheepAndRams(secretNumber, number) {
            var secretNumberArr = [],
                userInputArr = [],
                i,
                k,
                sheep = 0,
                rams = 0;

            for (var i = 0; i < secretNumber.length; i++) {
                secretNumberArr.push(secretNumber[i]);
            }

            for (var i = 0; i < number.length; i++) {
                userInputArr.push(number[i]);
            }

            for (var z = 0; z < secretNumberArr.length; z++) {
                if (userInputArr[z] === secretNumberArr[z]) {
                    rams++;
                    userInputArr[z] = '*';
                    secretNumberArr[z] = '@';
                }
            }

            for (i = 0; i < userInputArr.length; i++) {
                for (k = 0; k < secretNumberArr.length; k++) {
                    if (secretNumberArr[k] === userInputArr[i]) {
                        sheep++;
                        userInputArr[i] = '*';
                        secretNumberArr[k] = '@';
                    }
                }
            }

            return [sheep, rams];
        }

        return {
            validateUserInput: validateValue,
            checkSheepAndRams: checkSheepAndRams
        }

    }());

    return validator;
})
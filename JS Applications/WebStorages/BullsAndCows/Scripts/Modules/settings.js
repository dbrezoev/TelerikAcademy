define([], function () {
    'use strict'

    var settings = (function () {

        var digitsCount;

        return {
            setGame: function (num) {
                digitsCount = num;
            },
            getDigitsCount: function () {
                return digitsCount;
            }
        }
    }());

    return settings;
})
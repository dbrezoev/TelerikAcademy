/// <reference path="Libs/jquery-2.1.1.min.js" />
(function () {
    'use strict';

    require.config({
        paths: {
            jquery: 'Libs/jquery-2.1.1.min',
        }
    });

    require(['Modules/settings', 'Modules/game', 'jquery'], function (settings, game) {

        $('#start').one('click', function () {
            var userChoice = $('input[name=user-choice]:checked').val() | 0;
            settings.setGame(userChoice);
            $('#play').show();
            game.run();
        })

    });
}());
define([], function () {
    'use strict'
    var highScore = (function () {

        var getUserNameMessage = 'Please provide your nickname.'

        function saveHighscore(rounds) {
            var userName;
            
            rounds = rounds | 0;
            userName = prompt(getUserNameMessage);
            if (userName === undefined || userName === null) {

                //if user doesn't provide his nickname, he's not saved in highscore
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
            var i,
                players = [];

            for (i = 0; i < localStorage.length; i++) {
                players.push({
                    name: localStorage.key(i),
                    rounds: localStorage[localStorage.key(i)]
                });
            }

            players = sort(players);

            for (i = 0; i < players.length; i++) {
                $('#highscore').append($('<p>').html(i + 1 + '. ' + players[i].name + ' ' + players[i].rounds + ' rounds.'))
            }
        }

        function sort(players) {
            return players.sort(function (first, second) {
                return first.rounds - second.rounds;
            });
        }

        return {
            save: saveHighscore,
            render:renderHighscoreTable
        }

    }());
    return highScore;
})
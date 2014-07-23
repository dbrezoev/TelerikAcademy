define([], function () {
    'use strict'
    var highScore = (function () {
	
	String.prototype.htmlEscape = function (){
	var escapedStr = String(this).replace(/&/g, '&amp;');
	escapedStr = escapedStr.replace(/</g, '&lt;');
	escapedStr = escapedStr.replace(/>/g, '&gt;');
	escapedStr = escapedStr.replace(/"/g, '&quot;');
	escapedStr = escapedStr.replace(/'/g, "&#39");
	return escapedStr;
	}


        var getUserNameMessage = 'Please provide your nickname.'

        function saveHighscore(rounds) {
            var userName;
            
            rounds = rounds | 0;
            userName = prompt(getUserNameMessage);
			var escaped = userName.htmlEscape();
            if (escaped === undefined || escaped === null) {

                //if user doesn't provide his nickname, he's not saved in highscore
                return;
            }
            if (!localStorage[escaped]) {
                localStorage.setItem(escaped, rounds);
            }
            else {
                if (localStorage[escaped] > rounds) {
                    localStorage.setItem(escaped, rounds);
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
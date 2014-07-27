define(['Modules/Validator', 'Modules/HttpRequester', 'jquery'], function (validator, httpRequester) {

    var controller = (function () {

        var url = 'http://crowd-chat.herokuapp.com/posts';
        var INTERVAL = 1000;

        String.prototype.htmlEscape = function () {
            console.log('escaped');
            var escapedStr = String(this).replace(/&/g, '&amp;');
            escapedStr = escapedStr.replace(/</g, '&lt;');
            escapedStr = escapedStr.replace(/>/g, '&gt;');
            escapedStr = escapedStr.replace(/"/g, '&quot;');
            escapedStr = escapedStr.replace(/'/g, "&#39");
            return escapedStr;
        }

        function controlUserInteraction() {
            var $wrapper;
            $wrapper = $('#main');

            //logging in
            $wrapper.on('click', '#submit', function () {
                var username,
                    valid,
                    escaped;

                username = $('#log-in').val();               
                valid = validator.validateUser(username);
                if (!valid) {
                    validator.warn('#wrong-input', 'Invalid username!', 'red', 2000);
                    return;
                }                
                escaped = username.htmlEscape();
                sessionStorage.setItem('username', escaped);
                window.location = '#/chatroom'
            });

            //sending msg
            $wrapper.on('click', '#send-msg', function () {
                var text,
                    escaped;

                text = $('#user-msg').val();
                escaped = text.htmlEscape();

                httpRequester.postJSON(url, {
                    user: sessionStorage['username'],
                    text: escaped,
                })
                .then(function () {
                    validator.warn('#info', 'New message has been sent', 'green', 2000);
                }, function (error) {
                    validator.warn('#info', 'Error!', 'red', 2000);
                });
            });

            //get messages per second
            setInterval(function () {
                var i,
                    currentMSG,
                    p,
                    spanFrom,
                    spanMsg;

                httpRequester.getJSON(url)
                .then(function (data) {
                    $('#msg-box').empty();
                    
                    //parse data
                    for (i = 0; i < data.length; i++) {
                        currentMSG = data[i];
                        p = $('<p>');
                        spanFrom = $('<span>').css({ 'background-color': '#9999ff' }).html(currentMSG.by + ':   ');
                        spanMsg = $('<span>').html('       ' + currentMSG.text);
                        p.append(spanFrom).append(spanMsg);
                        $('#msg-box').append(p);
                        
                    }
                                        
                }, function (error) {
                    $('#msg-box').empty();
                    $('#msg-box').html('An Error Occured.');
                });
                var div = $('#msg-box').get(0);
                div.scrollTop = div.scrollHeight;
            }, INTERVAL);
        }               

        return {
            controlUserInteraction:controlUserInteraction
        }

    }());
    return controller;
});
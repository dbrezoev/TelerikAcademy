define(function () {
    var validator = (function () {
        var MIN_NAME_LENGTH = 3;
        var MAX_NAME_LENGTH = 10;

        function validateUser(username) {
            if (typeof(username) === 'string' || typeof(username) === 'String') {
                if(username.length > MIN_NAME_LENGTH && username.length < MAX_NAME_LENGTH){
                    return true;
                }
            }

            return false;
        }

        function writeInfo(selector, msg, color, fadeOut) {
            $(selector).html(msg).css({ color: color }).show().fadeOut(fadeOut);
        }

        return {
            validateUser: validateUser,
            warn: writeInfo
        }
    }());

    return validator;
});
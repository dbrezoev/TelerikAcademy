/*
Write a script that shims querySelector and querySelectorAll in older browsers
*/

//not fully shimmed
(function () {
    if (!document.hasOwnProperty('querySelector')) {

        document.querySelector = function (string) {

            var result;

            if (string[0] === '.') {
                result = document.getElementsByClassName(string.substring(1));

                return result[0];
            }
            else if (string[0] == '#') {
                result = document.getElementById(string.substring(1));
                return result;
            }
            else {
                return document.getElementsByTagName(string)[0];
            }
        }
    }

    if (!document.hasOwnProperty('querySelectorAll')) {

        document.querySelectorAll = function (string) {

            var result;

            if (string[0] === '.') {
                result = document.getElementsByClassName(string.substring(1));

                return result;
            }
            else {
                return document.getElementsByTagName(string);
            }
        }
    }
}());
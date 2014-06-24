var consoleModule = (function () {

    function writeLine(string) {
        var result = arguments[0].toString();

        for (var i = 1; i <= arguments.length; i++) {
            var regex = new RegExp('\\{' + (i - 1) + '\\}', 'g');
            result = result.replace(regex, arguments[i]);
        }
        console.log(result);
    }

    function writeError(string) {
        var result = arguments[0].toString();

        for (var i = 1; i <= arguments.length; i++) {
            var regex = new RegExp('\\{' + (i - 1) + '\\}', 'g');
            result = result.replace(regex, arguments[i]);
        }
        console.error(result);
    }

    function writeWarn(string) {
        var result = arguments[0].toString();

        for (var i = 1; i <= arguments.length; i++) {
            var regex = new RegExp('\\{' + (i - 1) + '\\}', 'g');
            result = result.replace(regex, arguments[i]);
        }
        console.warn(result);
    }
    
    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarn: writeWarn,
    }
}());


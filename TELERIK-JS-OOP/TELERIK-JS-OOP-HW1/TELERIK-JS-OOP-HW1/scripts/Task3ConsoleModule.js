var specialConsole = (function () {
    'use strict';

    function replaceHolders(currentMessage, currentArguments) {
        var i;
        for (i = 0; i < currentArguments.length; i += 1) {
            while (currentMessage.indexOf('{' + i + '}') !== -1) {
                currentMessage = currentMessage.replace('{' + i + '}', currentArguments[i + 1]);
            }
        }
        return currentMessage;
    }

    function writeLine(message, placeHolders) {
        if (placeHolders) {
            message = replaceHolders(message, arguments);
        }
        console.log(message);
    }

    function writeError(errorMessage, placeHolders) {
        if (placeHolders) {
            errorMessage = replaceHolders(errorMessage, arguments);
        }
        console.log(errorMessage);
    }


    function writeWarning(warningMessage, placeHolders) {
        if (placeHolders) {
            warningMessage = replaceHolders(warningMessage, arguments);
        }
        console.log(warningMessage);
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
}());


specialConsole.writeLine("Message: hello world");

specialConsole.writeLine("Message: {0} {1}", 1, "world");

specialConsole.writeError("Error: {0}", "Something happened");

specialConsole.writeWarning("Warning: {0}", "A warning");
/// <reference path="bower_components/underscore/underscore.js" />
/// <reference path="bower_components/jquery/dist/jquery.js" />
(function () {
    function clearLocalStorage() {
        localStorage.clear();
        loadPairs();
    }

    function loadPairs() {
        if (!localStorage.length || localStorage.length == 0) {
            document.getElementById("pairs-container").innerHTML = "name--->result";
            return;
        }
        var resultHTML = "<ul>";
        for (var i = 0; i < localStorage.length; i++) {
            var key = localStorage.key(i);
            resultHTML +=
            '<li>' +
             key + '<strong>---></strong>:' + localStorage.getItem(key) +
            '</li>';
        }
        resultHTML += "</ul>";
        document.getElementById("pairs-container").innerHTML = resultHTML;
    }

    function countBullsAndCows($guessNumber, realNumber) {
        var resultBulls = 0,
            resultCows = 0,
            realNumberAsString = JSON.stringify(realNumber);

        for (var i = 0; i < realNumberAsString.length; i++) {
            for (var j = 0; j < $guessNumber.length; j++) {
                if (realNumberAsString[i] === $guessNumber[j] && j == i) {
                    resultBulls += 1;
                }
                if (realNumberAsString[i] === $guessNumber[j] && j != i) {
                    resultCows += 1;
                }
            }
        }

        return {
            bulls: resultBulls,
            cows: resultCows
        };
    }

    function checkIfNumberIsWithUniqueDigits(number) {
        var numberAsString = JSON.stringify(number);

        for (var i = 0; i < numberAsString.length; i++) {
            for (var j = 0; j < numberAsString.length; j++) {
                if (i == j) {
                    continue;
                }
                if (numberAsString[i] === numberAsString[j]) {
                    return true
                }
            }
        }
        return false;
    }

    function generateRandomNumberWithDiffDigits(min, max) {
        var number = Math.floor(Math.random() * (max - min + 1)) + min;
        if (checkIfNumberIsWithUniqueDigits(number)) {
            return generateRandomNumberWithDiffDigits(min, max);
        }
        return number;
    }

    function saveToLocalStorage(value) {
        var key = document.getElementById("name-input").value;
        var value = value;
        localStorage.setItem(key, value);
    }

    var $container = $('#wrapper'),
        $saveScoreButton = $('#save-name'),
        $clearLocalStorageButton = $('#clear-local-storage'),
        $infoContainer = $('#player-info-wrapper').hide(),
        $guessNumberInnput = $('#number-to-guess'),
        $tryGuessNumber = $('#try-guess-number'),
        $errorMassage = $('<span>').appendTo($container).hide(),
        $numberOfBullsAndCows = $('<p>').addClass('bulls-cows-info').appendTo($container),
        playerGuesses = 0,
        computerNumber = generateRandomNumberWithDiffDigits(1000, 9999);
    console.log(computerNumber)
    $container.on('click', '#try-guess-number', function () {
        var $guessNumber,
            bullsAndCows;

        $guessNumber = $guessNumberInnput.val();

        if (isNaN($guessNumber) || $guessNumber.length != 4) {
            $errorMassage.html('Your number is not a number or with less or more than 4 digits').show();
        }
        else if (checkIfNumberIsWithUniqueDigits(parseInt($guessNumber))) {
            $errorMassage.html('All number digits must be different').show();
        }
        else {
            $errorMassage.hide();
            bullsAndCows = countBullsAndCows($guessNumber, computerNumber);
            playerGuesses++;
            $numberOfBullsAndCows.html('Bulls: ' + bullsAndCows.bulls + '<br/>Cows : ' + bullsAndCows.cows);

            if (bullsAndCows.bulls === 4) {
                $infoContainer.show();             
            }
        }     
    });

    $container.on('click', '#save-name', function () {
        saveToLocalStorage(playerGuesses);
        location.reload();
    })

    $clearLocalStorageButton.click(clearLocalStorage);

    $(document).ready(loadPairs);
}());

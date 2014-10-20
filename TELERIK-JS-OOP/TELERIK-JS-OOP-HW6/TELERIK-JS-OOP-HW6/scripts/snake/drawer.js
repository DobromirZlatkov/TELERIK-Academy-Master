'use strict';
var Snake = Snake || {};

Snake.drawer = (function () {

    var CELL_SIZE = 14;

    var appleImg = new Image();
    var borderImg = new Image();
    var stoneImg = new Image();
    var snakeImg = new Image();

    var appleKJS;
    var stoneKJS;
    var borderKJS;
    var snakeKJS;
    var snakeCells = [];

    (function setSources() {
        appleImg.src = 'images/apple.png';

        snakeImg.src = 'images/snake.png';
        appleKJS = new Kinetic.Image({
            name: 'apple',
            image: appleImg,
            width: 14,
            height: 14
        });

        snakeKJS = new Kinetic.Image({
            name: 'snake',
            image: snakeImg,
            width: 14,
            height: 14
        });
    }());

    function border(x, y, layer) {
        borderKJS.setX(x * CELL_SIZE);
        borderKJS.setY(y * CELL_SIZE);
        layer.add(borderKJS.clone());
    }


    function apple(x, y, layer) {
        appleKJS.setX(x * CELL_SIZE);
        appleKJS.setY(y * CELL_SIZE);
        layer.add(appleKJS);
    }

    function snake(cell, x, y, layer) {

        if (!snakeCells[cell]) {
            snakeCells[cell] = snakeKJS.clone();
        }

        snakeCells[cell].setX(x);
        snakeCells[cell].setY(y);
        layer.add(snakeCells[cell]);
    }

    function snakeDestroy() {

        for (var i = 1; i < snakeCells.length; i++) {
            snakeCells[i].destroy();
        }

        snakeCells = [];
    }

    return {
        apple: apple,
        snake: snake,
        snakeDestroy: snakeDestroy
    }

})();
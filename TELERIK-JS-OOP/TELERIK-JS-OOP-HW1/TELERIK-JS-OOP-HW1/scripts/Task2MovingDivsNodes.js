var addCircleBtn,
    movingShapes,
    addRectBtn;

movingShapes = (function () {
    'use strict';

    function generateRandomColor() {
        var red = Math.floor(Math.random() * 256),
            green = Math.floor(Math.random() * 256),
            blue = Math.floor(Math.random() * 256);

        return 'rgb(' + red + ',' + green + ',' + blue + ')';
    }

    function genrateCircularMovement(div) {
        var xcenter = 100,
            ycenter = 100,
            r = 50,
            speed = 0;

        setInterval(function () {
            var newLeft = Math.floor(xcenter + (r * Math.cos(speed))),
                newTop = Math.floor(ycenter + (r * Math.sin(speed)));

            speed += 0.1;
            div.style.border = '5px solid ' + generateRandomColor();
            div.style.backgroundColor = generateRandomColor();
            div.style.top = newTop + 'px';
            div.style.left = newLeft + 'px';
        }, 50);
    }

    function generateRectMovement(div) {
        var startX = 100,
            startY = 100,
            speed = 5,
            direction = 'right',
            lastDirection = 'up';
        setInterval(function () {

            div.style.border = '5px solid ' + generateRandomColor();
            div.style.backgroundColor = generateRandomColor();

            if (direction === 'right') {
                startX += speed;
                lastDirection = 'right';
            } else if (direction === 'left') {
                startX -= speed;
                lastDirection = 'left';
            } else if (direction === 'down') {
                startY += speed;
                lastDirection = 'down';
            } else if (direction === 'up') {
                startY -= speed;
                lastDirection = 'up';
            }

            if (startX >= 400 && lastDirection === 'right') {
                direction = 'down';

            } else if (startY >= 200 && lastDirection === 'down') {
                direction = 'left';

            } else if (startX < 100 && lastDirection === 'left') {
                direction = 'up';

            } else if (startY < 100 && lastDirection === 'up') {
                direction = 'right';
            }

            div.style.top = startY + 'px';
            div.style.left = startX + 'px';
        }, 50);
    }

    function add(shape) {
        var div = document.createElement('div'),
            container = document.getElementById('wrapper');
        //styles
        div.innerHTML = 'div';
        div.style.textAlign = 'center';
        div.style.width = '30px';
        div.style.height = '30px';
        div.style.border = '5px solid ' + generateRandomColor();
        div.style.backgroundColor = generateRandomColor();
        div.style.position = 'absolute';
        container.appendChild(div);

        if (shape === 'ellipse') {
            div.style.borderRadius = '15px';
            genrateCircularMovement(div);
        } else {
            generateRectMovement(div);
        }

    }


    return {
        add: add
    };

}());

addCircleBtn = document.getElementById('add-circle');
addCircleBtn.addEventListener('click', function () {
    'use strict';
    movingShapes.add('ellipse');
}, false);

addRectBtn = document.getElementById('add-rect');
addRectBtn.addEventListener('click', function () {
    'use strict';
    movingShapes.add('rect');
}, false);



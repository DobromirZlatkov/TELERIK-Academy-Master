function generateRandom(from, to) {
    return Math.floor(Math.random() * (to - from) + from);
}

function randomColor() {
    var randomRed = generateRandom(0, 255);
    var randomGreen = generateRandom(0, 255);
    var randomBlue = generateRandom(0, 255);

    return 'rgb(' + randomRed + ',' + randomGreen + ',' + randomBlue + ')';
}

function generateDiv() {
    var width = 100;
    var height = 100;

    var leftPos = 50;
    var topPos = 50;

    var borderRadius = 50;
    var borderWidth = 15;

    var div = document.createElement('div');

    div.style.position = 'absolute';
    div.style.left = leftPos + 'px';
    div.style.top = topPos + 'px';
    div.style.margin = 250 + 'px';
    div.style.width = width + 'px';
    div.style.height = height + 'px';
    div.style.backgroundColor = randomColor();
    div.style.border = borderWidth + 'px solid ' + randomColor();
    div.style.borderRadius = borderRadius + 'px';

    document.body.appendChild(div);
}

var i = 0;

for (var i = 0; i < 5; i++) {
    generateDiv();
}

var allDivs = document.getElementsByTagName('div'),
    angle = 0,
    radius = 50;

function animateDiv() {
    for (var i = 0; i < 5; i++) {
        allDivs[i].style.left = Math.cos(angle + 2 * Math.PI / allDivs.length * i) / radius * 10000 + 'px';
        allDivs[i].style.top = Math.sin(angle + 2 * Math.PI / allDivs.length * i) / radius * 10000 + 'px';
        allDivs[i].style.backgroundColor = randomColor();
        allDivs[i].style.border = 15 + 'px solid ' + randomColor();
        allDivs[i].style.width = generateRandom(10, 120) + 'px';
        allDivs[i].style.height = generateRandom(10, 120) + 'px';

    }
    angle = angle + 0.1;
    setTimeout(animateDiv, 100);
}

animateDiv();

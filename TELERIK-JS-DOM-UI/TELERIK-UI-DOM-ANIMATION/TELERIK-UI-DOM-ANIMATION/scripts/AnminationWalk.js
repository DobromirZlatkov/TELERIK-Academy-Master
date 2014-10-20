var secondMonsterImage = new Image();
secondMonsterImage.src = "../pictures/monsterSpriteSheet.png";
var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

var sx = 0,
    sy = 0,
    sw = 100,
    sh = 100,
    dx = 0,
    dy = 10,
    dw = 160,
    dh = 160;


function moveBackground() {

    var paper = new Raphael(9,25, 0, 0);
    var background = paper.image("pictures/background.jpg", 0, 150, 1000,100);
   // var x = 
    paper.setSize(200, 200);

    background.animate({
        x: -800,        
    }, 2000);
    
}
setInterval(function () { moveBackground(); }, 2000);

setInterval(function move2() {
    if (dx >= 1300) {
        dx = 0;
    }
    if (sx == 700) {
        sx = 0;
    }
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    ctx.drawImage(secondMonsterImage, sx, sy, sw, sh, dx, dy, dw, dh);
    sx += 100;
    //dx += 15;
}, 100);








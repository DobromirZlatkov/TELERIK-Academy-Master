(function () {
    require(['shapes/shape', 'shapes/rect', 'shapes/circle', 'shapes/quadrat'], function (Shape, Rect, Circle, Quadrat) {

        var mousePos;

        window.onmousemove = handleMouseMove;
        setInterval(getMousePosition, 10); // setInterval repeats every X ms

        function handleMouseMove(event) {
            event = event || window.event; // IE-ism
            mousePos = {
                x: event.clientX,
                y: event.clientY
            };
        }
        function getRandomColor() {
            var red = Math.floor(Math.random() * 255) + 0;
            var green = Math.floor(Math.random() * 255) + 0;
            var blue = Math.floor(Math.random() * 255) + 0;
            return 'rgb(' + red + ',' + green + ',' + blue + ')';
        }
        function getMousePosition() {
            var pos = mousePos;
            var rect = new Rect(pos.x, pos.y, 100, 100);

            rect.draw(getRandomColor(), getRandomColor());

        }
    });
}());

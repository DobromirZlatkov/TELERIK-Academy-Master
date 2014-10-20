define(function () {
    var Shape;
    Shape = (function () {

        function Shape(x, y) {
            this._x = x;
            this._y = y;
        }

        Shape.prototype = {
            draw: function (strokeColor, fillColor) {
                var canvas = document.getElementById('the-canvas');
                var ctx = canvas.getContext("2d");
                ctx.beginPath();
                return {
                    ctx: ctx,
                    canvas: canvas
                }
            },
            move: function (newX, newY) {

            },            
        }

        return Shape;
    }());
    return Shape;
});
var Shapes = (function () {
    'use strict';
    var Shape,
        Line,
        Circle,
        Rect;

    Shape = (function () {
        function Shape(x, y, context) {
            this._x = x;
            this._y = y;
            this._context = context;
        }

        Shape.prototype.draw = function () {
            var canvas = document.getElementById(this._context),
                ctx = canvas.getContext("2d");
            ctx.beginPath();
            return ctx;
        };

        return Shape;
    }());


    Rect = (function () {
        function Rect(x, y, context, width, height) {
            Shape.call(this, x, y, context);
            this._width = width;
            this._height = height;
        }

        Rect.prototype = new Shape();

        Rect.prototype.draw = function () {
            var context = Shape.prototype.draw.call(this);
            context.rect(this._x, this._y, this._width, this._height);
            context.fill();
            context.stroke();
            context.closePath();
        }

        return Rect;
    }());


    Circle = (function () {
        'use strict';
        function Circle(x, y, context, radius) {
            Shape.call(this, x, y, context);
            this._radius = radius;
        }

        Circle.prototype = new Shape();

        Circle.prototype.draw = function () {
            var context = Shape.prototype.draw.call(this);
            context.arc(this._x, this._y, this._radius, 0, 2 * Math.PI);
            context.stroke();
            context.closePath();
        }

        return Circle;
    }());


    Line = (function () {
        function Line(x, y, canvas, endX, endY) {
            Shape.call(this, x, y, canvas);
            this._endX = endX;
            this._endY = endY;
        }

        Line.prototype = new Shape();

        Line.prototype.draw = function () {
            var context = Shape.prototype.draw.call(this);
            context.moveTo(this._x, this._y);
            context.lineTo(this._endX, this._endY);
            context.stroke();
            context.closePath();
        }

        return Line;
    }());


    return {
        Rect: Rect,
        Circle: Circle,
        Line: Line
    }
}());



var rect = new Shapes.Rect(0, 0, 'the-canvas', 50, 50);
rect.draw();
var circle = new Shapes.Circle(100, 100, 'the-canvas', 30);
circle.draw();
var line = new Shapes.Line(100, 0, 'the-canvas', 200, 100);
line.draw();

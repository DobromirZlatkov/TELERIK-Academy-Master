define(['shapes/shape'], function (Shape) {
    var Rect;
    Rect = (function () {

        function Rect(x, y, width, height) {
            Shape.call(this, x, y);
            this._width = width;
            this._height = height;
            this._fillColor;
            this._strokeColor;
        }

        Rect.prototype = new Shape();

        Rect.prototype = {
            draw: function (fillColor, strokeColor) {
                this._fillColor = fillColor;
                this._strokeColor = strokeColor;
                var ctx = Shape.prototype.draw.call(this, strokeColor, fillColor);                
                ctx.ctx.rect(this._x, this._y, this._width, this._height);
                ctx.ctx.fillStyle = this._fillColor;
                ctx.ctx.fill();
                ctx.ctx.lineWidth = 7;
                ctx.ctx.strokeStyle = this._strokeColor;
                ctx.ctx.stroke();
               
            },
            move: function (x, y) {
                var ctx = Shape.prototype.draw.call(this);
                ctx.ctx.clearRect(0,0,ctx.canvas.width, ctx.canvas.height);
                var newRect = new Rect(x, y, this._width, this._height);
                newRect.draw(this._fillColor, this._strokeColor);            
            }
            
        }


        return Rect;
    }());
    return Rect;
})
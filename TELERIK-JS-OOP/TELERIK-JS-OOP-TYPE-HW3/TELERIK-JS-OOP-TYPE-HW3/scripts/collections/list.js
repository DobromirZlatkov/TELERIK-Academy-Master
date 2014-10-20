var Collections;
(function (Collections) {
    var List = (function () {
        function List() {
            this._colletion = [];
        }
        List.prototype.add = function (item) {
            this._colletion.push(item);
        };

        Object.defineProperty(List.prototype, "count", {
            get: function () {
                return this._colletion.length;
            },
            enumerable: true,
            configurable: true
        });
        return List;
    })();
    Collections.List = List;
})(Collections || (Collections = {}));

var someList = new Collections.List();
someList.add(10);
//# sourceMappingURL=list.js.map

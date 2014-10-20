define(function (Item) {
    'use strict';
    var Section;
    Section = (function () {

        function Section(title) {
            this._title = title;
            this._items = [];
            
        }

        Section.prototype = {
            add: function (item) {
                this._items.push(item);
                return this;
            },
            getData: function () {
                var items = [], i, len, currentItem;

                for (i = 0, len = this._items.length; i < len; i += 1) {
                    currentItem = this._items[i];
                    items.push(currentItem.getData());
                }

                return {
                    title: this._title,
                    items: items
                };
            }
        };

        return Section;
    })();

    return Section;
});
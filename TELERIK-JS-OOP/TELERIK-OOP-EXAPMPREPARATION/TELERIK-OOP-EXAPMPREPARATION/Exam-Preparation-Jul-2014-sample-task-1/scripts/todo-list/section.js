define(['todo-list/item'], function (item) {
    'use strict';
    var Section;
    Section = (function () {
 
        function Section(title) {
            this.title = title;
            this.items = [];
        }

        Section.prototype = {
            add: function (currentItem) {
                if (!(currentItem instanceof item)) {
                    throw {
                        massage: 'You can add only items in section',
                    }
                }
                else {
                    this.items.push(currentItem);
                }
                return this;
            },
            getData: function () {
                return {
                    title: this.title,
                    items: this.items

                }
            }
            ///TO DO......
        }

        return Section;
    }());
    return Section;
})
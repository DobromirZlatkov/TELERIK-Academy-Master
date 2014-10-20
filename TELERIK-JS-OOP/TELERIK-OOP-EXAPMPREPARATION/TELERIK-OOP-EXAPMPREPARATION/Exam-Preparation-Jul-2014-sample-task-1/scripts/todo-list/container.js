define(['todo-list/section'], function (section) {
    'use strict';
    var Container;
    Container = (function () {

        function Container() {
            this.sections = [];
        }

        Container.prototype = {
            add: function (currentSection) {
                if (!(currentSection instanceof section)) {
                    throw {
                        massage: 'Container cann add only sections'
                    }
                }
                else {
                    this.sections.push(currentSection);
                    return this;
                }

            },
            getData: function () {
                var result = [];
                for (var i = 0; i < this.sections.length; i++) {
                    result[i] = this.sections[i];
                }
                return result;
            }
        }

        return Container;
    }());
    return Container;
});
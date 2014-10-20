define([], function () {
    var Store;
    Store = (function () {
    

        function Store(name) {
            if (name.length < 6 || name.length > 30) {
                throw {
                    massage: 'Store name must be between 6 and 30 chars'
                }
            }
            this._name = name;
            this._items = [];
        }

        function sortLexicographicallyByType(items ,type, type2) {
            var sortedItems = [], i, len;
            for (i = 0, len = items.length; i < len ; i += 1) {
                if (items[i].type == type || items[i].type == type2) {
                    sortedItems.push(items[i]);
                }
            }
            sortedItems.sort(function (a, b) { return a.name.localeCompare(b.name); });
            return sortedItems;
        }

        Store.prototype = {
            addItem: function (item) {
                this._items.push(item);
                return this;
            },
            getAll: function () {
                var allSortedItems = [];
                for (var i = 0; i < this._items.length ; i++) {
                    allSortedItems.push(this._items[i]);
                }
                allSortedItems.sort(function (a, b) { return a.name.localeCompare(b.name); });
                return allSortedItems;
            },
            getSmartPhones: function () {
               return sortLexicographicallyByType(this._items, 'smart-phone');
            },
            getMobiles: function () {
                return sortLexicographicallyByType(this._items, 'smart-phone', 'tablet');
            },
            getComputers: function () {
                return sortLexicographicallyByType(this._items, 'pc', 'notebook');
            },
            filterItemsByType: function (filterType) {
                return sortLexicographicallyByType(this._items, filterType.toLowerCase());
            },
            filterItemsByPrice: function (options) {
                var max, min, filteredByPriceElements = [], i, len;
                if (!(options == undefined)) {
                    max = options.max || Infinity;
                    min = options.min || 0;

                }
                else {
                    max = Infinity;
                    min = 0;
                }
                for (i = 0, len = this._items.length; i < len; i += 1) {
                    if (this._items[i].price <= max && this._items[i].price >= min) {
                        filteredByPriceElements.push(this._items[i]);
                    }
                }
                filteredByPriceElements.sort(function (a, b) {
                    return a.price - b.price;
                })
                return filteredByPriceElements;
            },
            countItemsByType: function () {
                var numberOfItemsByType = [];
                for (var i = 0; i < this._items.length; i++) {
                    var currentType = this._items[i].type;
                    if (numberOfItemsByType[currentType] !== undefined) {
                        numberOfItemsByType[currentType] += 1;
                    }
                    else {
                        numberOfItemsByType[currentType] = 1
                    }
                }
                return numberOfItemsByType;
            },
            filterItemsByName: function (partOfName) {
                var itemsBySearchName = [];
                for (var i = 0; i < this._items.length; i++) {
                    if (this._items[i].name.toLowerCase().indexOf(partOfName.toLowerCase()) > -1) {
                        itemsBySearchName.push(this._items[i]);
                    }
                }
                itemsBySearchName.sort(function (a, b) { return a.name.localeCompare(b.name); });
                return itemsBySearchName;
            }
        }
        return Store;
    }())

    return Store;
})
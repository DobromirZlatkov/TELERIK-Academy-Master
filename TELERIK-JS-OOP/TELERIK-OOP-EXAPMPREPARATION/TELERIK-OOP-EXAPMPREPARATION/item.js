define(function () {
    var Item;
    Item = (function () {
     
        function Item(type, name, price) {
            if (type == 'smart-phone' || type == 'accessory' || type == 'notebook' || type == 'pc' || type == 'tablet') {
                this.type = type;
            }
            else {
                throw {
                    massage:'Unexisting type of item'
                }
            }
            if (name.length > 40 || name.length < 6) {
                throw {
                    massage : 'Item name must be between 6 and 40 symbols'
                }
            }
            else {
                this.name = name;
            }
           
            this.price = price;
        }
        return Item;
    }());
    return Item;
})
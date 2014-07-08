define(function () {
    'use strict';
    var Item;
    Item = (function () {

        var validTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];        

        function validateType() {
            for (var i = 0; i < validTypes.length; i++) {                
                if(this.type === validTypes[i]){
                    return true;
                }
            }

            return false;
        }

        function validateName() {
            if (typeof (this.name) == 'string' || typeof (this.name) == 'String') {
                if (this.name.length >= 6 && this.name.length <= 40) {
                    return true;
                }
            }

            return false;
        }

        function validatePrice() {
            if (this.price < 0) {
                return false;
            }

            return true;
        }

        function Item(type, name, price) {
            this.type = type;
            if (!validateType.call(this, type)) {
                throw new Error('Invalid Item type!');
            }

            this.name = name;
            if (!validateName.call(this)) {
                throw new Error('Invalid Item name!');
            }

            this.price = price;
            if (!validatePrice.call(this)) {
                throw new Error('Item`s price cannot be less than zero!');
            }
        }        

        return Item;
    })();
    return Item;
});
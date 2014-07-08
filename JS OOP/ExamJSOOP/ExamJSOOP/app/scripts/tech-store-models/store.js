define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;
    Store = (function () {

        function validateName() {
            if (typeof(this.name) == 'string' || typeof(this.name) == 'String') {
                if(this.name.length > 6 && this.name.length < 30){
                    return true;
                }
            }

            return false;
        }

        function filterByType(arrayToBeFiltered, arrayOfTypes) {
            var result = [];            
            var arrayOfTypes = arrayOfTypes || ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];
            for (var i = 0; i < arrayToBeFiltered.length; i++) {
                var currentItem = arrayToBeFiltered[i];
                for (var k = 0; k < arrayOfTypes.length; k++) {
                    if (currentItem.type == arrayOfTypes[k]) {
                        result.push(currentItem);
                    }
                }
            }

            return result;
        }

        function sortByName(items) {
            return items.sort(function (first, second) {
                if (first.name < second.name) {
                    return -1;
                }
                if (first.name > second.name) {
                    return 1;
                }
                return 0;
            });
        }

        function Store(name) {
            this.name = name;
            if (!validateName.call(this)) {
                throw new Error('Invalid Store name!');
            }

            this.itemsList = [];
        }

        Store.prototype = {

            addItem: function (item) {
                if (item instanceof Item) {
                    this.itemsList.push(item);
                }
                else {
                    throw new Error('Store can keep only items.');
                }

                return this;
            },
            getAll: function () {
                var sortedItems;
                sortedItems = this.itemsList.sort();

                return sortedItems;
            },
            getSmartPhones: function () {
                var sortedSmartPhones = filterByType(this.itemsList, ['smart-phone']);

                sortedSmartPhones = sortByName(sortedSmartPhones);

                return sortedSmartPhones;                
            },
            getMobiles: function () {
                var sortedMobiles = filterByType(this.itemsList, ['smart-phone', 'tablet']);
                sortedMobiles = sortByName(sortedMobiles);
                return sortedMobiles;                
            },
            getComputers: function () {
                var sortedComputers = filterByType(this.itemsList, ['pc', 'notebook']);
                sortedComputers = sortByName(sortedComputers);
                
                return sortedComputers;                
            },
            filterItemsByType: function (filterType) {
                var filteredItems,
                    i,
                    currentItem;

                filteredItems = [];
                for (i = 0; i < this.itemsList.length; i++) {
                    currentItem = this.itemsList[i];
                    if (currentItem.type === filterType) {
                        filteredItems.push(currentItem);
                    }
                }
                filteredItems = sortByName(filteredItems);
                return filteredItems;
            },
            filterItemsByPrice: function (options) {
                var options,
                    i,
                    result,
                    currentItem,
                        result;

                //handle optional parameter
                if (!options) {
                    options = options || {
                        min: 0,
                        max: Number.MAX_VALUE
                    }
                }
                else {
                    if (options.min == undefined) {
                        options.min = 0;
                    }

                    if (options.max == undefined) {
                        options.max = Number.MAX_VALUE;
                    }
                }

                result = [];
                for (i = 0; i < this.itemsList.length; i++) {
                    currentItem = this.itemsList[i];
                    if (currentItem.price >= options.min && currentItem.price <= options.max) {
                        result.push(currentItem);
                    }
                }
                result = result.sort(function (first, second) {
                    return first.price - second.price;
                });

                return result;                
            },
            countItemsByType: function () {
                var result,
                    i,
                    currentItem;

                result = {};
                for (i = 0; i < this.itemsList.length; i++) {
                    var currentItem = this.itemsList[i];
                    if (!result[currentItem.type]) {
                        result[currentItem.type] = 1;
                    }
                    else {
                        result[currentItem.type] += 1;
                    }
                }

                return result;
            },
            filterItemsByName: function (partOfName) {
                var filteredItems,
                    i,
                    currentItem,
                    currentName;

                filteredItems = [];
                for (i = 0; i < this.itemsList.length; i++) {
                    currentItem = this.itemsList[i];
                    currentName = currentItem.name.toLowerCase();
                    if (currentName.indexOf(partOfName) !== -1) {
                        filteredItems.push(currentItem);
                    }
                }
                filteredItems = sortByName(filteredItems);
                
                return filteredItems;
            },            
        }

        return Store;
    })();
    return Store;
});
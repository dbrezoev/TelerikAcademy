var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Hardware;
(function (Hardware) {
    var Battery = (function () {
        function Battery(model, idle, batteryType) {
            this.model = model;
            this.idle = idle;
            this.batteryType = batteryType;
        }
        Object.defineProperty(Battery.prototype, "idle", {
            get: function () {
                return this._idle;
            },
            set: function (newIdle) {
                if (newIdle < 0) {
                    throw new Error('Battery idle cannot be negative number.');
                }

                this._idle = newIdle;
            },
            enumerable: true,
            configurable: true
        });


        Battery.prototype.displayInfo = function () {
            var result = ' Battery - Model: ' + this.model + '; Idle: ' + this.idle + '; Battery Type: ' + this.displayBatteryType(this.batteryType);
            return result;
        };

        Battery.prototype.displayBatteryType = function (batteryType) {
            if (batteryType == 0 /* Liion */) {
                return 'Liion';
            } else if (batteryType == 2 /* NiCd */) {
                return 'NiCd';
            } else if (batteryType == 1 /* NiMH */) {
                return 'NiMH';
            }
        };
        return Battery;
    })();
    Hardware.Battery = Battery;

    (function (BatteryType) {
        BatteryType[BatteryType["Liion"] = 0] = "Liion";
        BatteryType[BatteryType["NiMH"] = 1] = "NiMH";
        BatteryType[BatteryType["NiCd"] = 2] = "NiCd";
    })(Hardware.BatteryType || (Hardware.BatteryType = {}));
    var BatteryType = Hardware.BatteryType;

    var MobileDevice = (function () {
        function MobileDevice(model, price, battery) {
            this.battery = battery;
            this.model = model;
            this.price = price;
        }
        Object.defineProperty(MobileDevice.prototype, "model", {
            get: function () {
                return this._model;
            },
            set: function (newModel) {
                if (newModel == '') {
                    throw new Error('Invalid name to the mobile device.');
                }

                this._model = newModel;
            },
            enumerable: true,
            configurable: true
        });


        Object.defineProperty(MobileDevice.prototype, "price", {
            get: function () {
                return this._price;
            },
            set: function (newPrice) {
                if (newPrice < 0) {
                    throw new Error('Invalid price for the mobile device.');
                }

                this._price = newPrice;
            },
            enumerable: true,
            configurable: true
        });


        MobileDevice.prototype.displayInfo = function () {
            var result = 'Model: ' + this.model + '; Price: ' + this.price + 'euro';
            return result;
        };
        return MobileDevice;
    })();
    Hardware.MobileDevice = MobileDevice;

    var GSM = (function (_super) {
        __extends(GSM, _super);
        function GSM(model, price, battery) {
            _super.call(this, model, price, battery);
            this.callHistory = [];
        }
        GSM.prototype.displayInfo = function () {
            var result = '--GSM--' + '\r\n' + _super.prototype.displayInfo.call(this) + ' ' + this.battery.displayInfo();
            return result;
        };

        GSM.prototype.addCall = function (call) {
            this.callHistory.push(call);
        };

        GSM.prototype.removeLastCall = function () {
            this.callHistory.pop();
        };

        GSM.prototype.clearCalls = function () {
            this.callHistory = [];
        };

        GSM.prototype.displayCallHistory = function () {
            if (this.callHistory.length == 0) {
                return 'No calls recorded.';
            }
            var result = '';
            for (var i = 0; i < this.callHistory.length; i++) {
                var currentCall = this.callHistory[i];
                result += currentCall.displayInfo();
            }

            return result;
        };
        return GSM;
    })(MobileDevice);
    Hardware.GSM = GSM;

    var Reader = (function (_super) {
        __extends(Reader, _super);
        function Reader(model, price, battery, booksCount) {
            _super.call(this, model, price, battery);
            this.battery = battery;
            this.booksCount = booksCount;
        }
        Reader.prototype.displayInfo = function () {
            var result = '--E-Reader--' + '\r\n' + _super.prototype.displayInfo.call(this) + ' ' + this.battery.displayInfo() + '; Books in it: ' + this.booksCount;

            return result;
        };
        return Reader;
    })(MobileDevice);
    Hardware.Reader = Reader;

    var GamingConsole = (function (_super) {
        __extends(GamingConsole, _super);
        function GamingConsole(model, price, battery, gamesInstalled) {
            _super.call(this, model, price, battery);
            this.gamesInstalled = gamesInstalled;
        }
        GamingConsole.prototype.displayInfo = function () {
            var result = '--GamingConsole--' + '\r\n' + _super.prototype.displayInfo.call(this) + ' ' + this.battery.displayInfo() + '; Games in it: ' + this.gamesInstalled;

            return result;
        };
        return GamingConsole;
    })(MobileDevice);
    Hardware.GamingConsole = GamingConsole;
})(Hardware || (Hardware = {}));
//# sourceMappingURL=Hardware.js.map

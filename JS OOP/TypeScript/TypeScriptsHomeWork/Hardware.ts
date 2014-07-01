module Hardware {
    export class Battery {

        private model: string;
        private _idle: number;
        private batteryType: BatteryType;

        constructor(model: string, idle: number, batteryType: BatteryType) {
            this.model = model;
            this.idle = idle;
            this.batteryType = batteryType;
        }
        get idle() {
            return this._idle;
        }

        set idle(newIdle: number) {
            if (newIdle < 0) {
                throw new Error('Battery idle cannot be negative number.');
            }

            this._idle = newIdle;
        }

        displayInfo() {
            var result =  ' Battery - Model: ' + this.model + '; Idle: ' + this.idle +
                '; Battery Type: ' + this.displayBatteryType(this.batteryType);
            return result;
        }

        displayBatteryType(batteryType: BatteryType) : string {
            if (batteryType == BatteryType.Liion) {
                return 'Liion';
            }
            else if (batteryType == BatteryType.NiCd) {
                return 'NiCd';
            }
            else if (batteryType == BatteryType.NiMH) {
                return 'NiMH';
            }
        }

    }

    export enum BatteryType {
        Liion,
        NiMH,
        NiCd
    }

    export class MobileDevice implements Interfaces.IMobileDevice, Interfaces.IDisplayInfo {

        private _model: string;
        private _price: number;
        constructor(model: string, price: number, public battery: Battery) {
            this.model = model;
            this.price = price;
        }

        get model() {
            return this._model;
        }

        set model(newModel:string) {
            if(newModel == '') {
                throw new Error('Invalid name to the mobile device.');
            }

            this._model = newModel;
        }

        get price() {
            return this._price;
        }

        set price(newPrice:number) {
            if(newPrice < 0) {
                throw new Error('Invalid price for the mobile device.');
            }

            this._price = newPrice;
        }

        displayInfo() {
            var result = 'Model: ' + this.model + '; Price: ' + this.price + 'euro';
            return result;
        }
    }

    export class GSM extends MobileDevice implements Interfaces.IDisplayInfo, Interfaces.IGSM {

        private callHistory: Software.Call[] = [];

        constructor(model: string, price: number, battery: Battery) {
            super(model, price, battery);
        }

        displayInfo() {
            var result = '--GSM--' + '\r\n' +  super.displayInfo() + ' ' + this.battery.displayInfo();
            return result;
        }

        addCall(call: Software.Call) {
            this.callHistory.push(call);
        }

        removeLastCall() {
            this.callHistory.pop();
        }

        clearCalls() {
            this.callHistory = [];
        }

        displayCallHistory() {
            if (this.callHistory.length == 0) {

                return 'No calls recorded.';
            }
            var result = '';
            for (var i = 0; i < this.callHistory.length; i++) {
                var currentCall = this.callHistory[i];
                 result += currentCall.displayInfo();                
            }                      

            return result;
        }
    }

    export class Reader extends MobileDevice implements Interfaces.IDisplayInfo {

        private booksCount: number;

        constructor(model: string, price: number, battery: Battery,
            booksCount: number) {
            super(model, price, battery);
            this.battery = battery;
            this.booksCount = booksCount;
        }

        displayInfo() {
            var result = '--E-Reader--' + '\r\n' + super.displayInfo() + ' ' + this.battery.displayInfo() +
                '; Books in it: ' + this.booksCount;

            return result;
        }
    }

    export class GamingConsole extends MobileDevice implements Interfaces.IDisplayInfo {

        private gamesInstalled: number;

        constructor(model: string, price: number, battery: Battery,
            gamesInstalled: number) {
            super(model, price, battery);
            this.gamesInstalled = gamesInstalled;
        }

        displayInfo() {
        var result = '--GamingConsole--' + '\r\n' +super.displayInfo() + ' ' + this.battery.displayInfo() + 
            '; Games in it: ' + this.gamesInstalled;

            return result;
        }
    }
}

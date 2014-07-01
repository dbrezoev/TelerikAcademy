var devices = [];

var gsm = new Hardware.GSM('Nokia', 120, new Hardware.Battery('Toshiba', 24, Hardware.BatteryType.Liion));

var reader = new Hardware.Reader('MEGA READER', 123, new Hardware.Battery('Varta', 150, Hardware.BatteryType.NiMH), 30);

var gameConsole = new Hardware.GamingConsole('SEGA', 160, new Hardware.Battery('BAT', 300, Hardware.BatteryType.NiMH), 6);

devices.push(gsm);
devices.push(reader);
devices.push(gameConsole);

for (var i = 0; i < devices.length; i++) {
    var currentDevice = devices[i];
    console.log(currentDevice.displayInfo());
}

//add some calls in the gsm

gsm.addCall(new Software.Call(35, '0888 888 888', new Date()));
gsm.addCall(new Software.Call(14, '0888 111 111', new Date()));
gsm.addCall(new Software.Call(28, '0888 222 222', new Date()));


//tests for call functionality
console.log(gsm.displayCallHistory());

gsm.removeLastCall();
console.log(gsm.displayCallHistory());

gsm.clearCalls();
console.log(gsm.displayCallHistory());

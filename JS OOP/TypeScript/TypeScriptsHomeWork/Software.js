var Software;
(function (Software) {
    var Call = (function () {
        function Call(duration, phoneNumber, dateTime) {
            this.duration = duration;
            this.phoneNumber = phoneNumber;
            this.dateTime = dateTime;
        }
        Call.prototype.displayInfo = function () {
            var result = 'Duration: ' + this.duration + 'sec;' + '\r\n' + 'PhoneNumber: ' + this.phoneNumber + ';' + '\r\n' + 'Date called: ' + this.dateTime + '\r\n';
            return result;
        };
        return Call;
    })();
    Software.Call = Call;
})(Software || (Software = {}));
//# sourceMappingURL=Software.js.map

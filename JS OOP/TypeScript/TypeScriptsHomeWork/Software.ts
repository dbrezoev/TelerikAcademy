module Software {
    export class Call implements Interfaces.IDisplayInfo {

        private duration: number;
        private phoneNumber: string;
        private dateTime: Date;

        constructor(duration: number, phoneNumber: string, dateTime: Date) {
            this.duration = duration;
            this.phoneNumber = phoneNumber;
            this.dateTime = dateTime;
        }

        displayInfo() {
            var result = 'Duration: ' + this.duration + 'sec;' + '\r\n'+'PhoneNumber: ' +
                this.phoneNumber + ';' + '\r\n'+'Date called: ' + this.dateTime + '\r\n';
            return result;
        }
    }
} 
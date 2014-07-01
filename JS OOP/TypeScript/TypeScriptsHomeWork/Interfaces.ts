module Interfaces {
    export interface IDisplayInfo {
        displayInfo(): string;
    } 

    export interface IGSM {

        addCall(call: Software.Call): void;
        removeLastCall(): void;
        clearCalls(): void;
        displayCallHistory(): void;
    } 

    export interface IMobileDevice {
        price: number;
        model: string;
    } 
}
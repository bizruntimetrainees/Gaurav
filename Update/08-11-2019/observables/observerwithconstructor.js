"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
function sequenceSubscriber(observer) {
    observer.next(1);
    observer.next(2);
    observer.next(3);
    observer.complete();
}
var sequence = new rxjs_1.Observable(sequenceSubscriber);
sequence.subscribe({
    next: function (num) { console.log(num); },
    complete: function () { console.log('Finished sequence'); }
});

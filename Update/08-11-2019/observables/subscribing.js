"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var myObservable = rxjs_1.of(1, 2, 3);
var myObserver = {
    next: function (x) { return console.log('Observer got a next value: ' + x); },
    error: function (err) { return console.error('Observer got an error: ' + err); },
    complete: function () { return console.log('Observer got a complete notification'); }
};
myObservable.subscribe(myObserver);

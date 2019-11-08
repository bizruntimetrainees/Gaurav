"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
function fromEvent(target, eventName) {
    return new rxjs_1.Observable(function (observer) {
        var handler = function (e) { return observer.next(e); };
        // Add the event handler to the target
        target.addEventListener(eventName, handler);
        return function () {
            // Detach the event handler from the target
            target.removeEventListener(eventName, handler);
        };
    });
}
var ESC_KEY = 27;
var nameInput = document.getElementById('name');
var subscription = fromEvent(nameInput, 'keydown')
    .subscribe(function (e) {
    if (e.keyCode === ESC_KEY) {
        nameInput.value = '';
    }
});

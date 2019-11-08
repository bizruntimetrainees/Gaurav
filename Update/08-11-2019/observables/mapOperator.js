"use strict";
exports.__esModule = true;
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
var nums = rxjs_1.of(1, 2, 3);
var squareValues = operators_1.map(function (val) { return val * val; });
var squaredNums = squareValues(nums);
squaredNums.subscribe(function (x) { return console.log(x); });

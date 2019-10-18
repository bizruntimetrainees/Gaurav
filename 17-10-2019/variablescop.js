var global = 1254; // global
var Scope = /** @class */ (function () {
    function Scope() {
        this.num = 100; // property
    }
    Scope.prototype.scope = function () {
        console.log("this is method");
        var a = 100; // local variable
        console.log("local value:" + a);
        console.log("Global variable:" + global);
    };
    Scope.val = "hello";
    return Scope;
}());
var obj1 = new Scope();
obj1.scope();
console.log(Scope.val);
console.log(obj1.scope());
console.log("class proeperty:" + obj1.num);

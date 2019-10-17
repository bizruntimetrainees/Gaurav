var global : number= 1254; // global

class Scope
{
    static val : string ="hello";
    
    scope() : void
    {
        console.log("this is method");
        var a : number = 100; // local variable
        console.log("local value:"+a);
        console.log("Global variable:"+global);
    }
  num : number = 100; // property
  
}
var obj1 = new Scope()
obj1.scope();
console.log(Scope.val);
console.log(obj1.scope());
console.log("class proeperty:"+obj1.num);
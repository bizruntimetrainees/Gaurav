interface ReadOnly
{
    name : string;
    readonly SSN :number
}
var fun : ReadOnly={SSN : 12458,name : "Hello"};
   fun.name = "hello";
for(var h in fun)
{
   console.log(h);
}
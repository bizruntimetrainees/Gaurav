interface keyValueProcess
{
    (key:number,
    value : string):void
}
function addkeyvalue(key : number,value : string)
{
    console.log("keyvalue is:" +key+"  "+value);
}
function UpdateKeyValue(key : number,value:string)
{
    console.log("updated :"+key+"  "+value);
}
var kvp : keyValueProcess = addkeyvalue;
kvp(1,"Ramu");

var ukvp : keyValueProcess = UpdateKeyValue;
ukvp(5,"Shyam");


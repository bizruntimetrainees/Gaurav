interface ArrayType
{
    [index : number]:number
}

var numArr :ArrayType = [12,52,20,5];
numArr[0];
numArr[1];
numArr[2];
numArr[3];

for(var Arr in numArr)
{
    console.log(Arr);
}

interface ArrayString
{
    [index:string]:string
}
  let str : ArrayString
  str["TS"] = "TypeScript";
str["JS"] = "JavaScript";

  for(var s in str)
  {
      console.log(s);
  }

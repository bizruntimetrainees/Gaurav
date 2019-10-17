var func = (x)=>
{
   if(typeof x == "number")
   {
       console.log("x is numeric");
   }else if(typeof x == "string")
   {
       console.log("x is string");
   }
}
func(100);
func("hello");
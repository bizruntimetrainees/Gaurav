function rest(...nums:number[])
{
   var i ;

   var sum : number = 0;

   for(i =0; i<nums.length;i++)
   {
       sum = sum + nums[i];
   }
   console.log("sum is "+sum);
}
rest(1,2,54,78,5,0,120);
rest(1000,2000,1478,52015,5487,0);
function param(price:number,percent : number =0.5)
{
    var discount = price*percent;
    console.log("Discount is:"+discount);
}
param(1000);
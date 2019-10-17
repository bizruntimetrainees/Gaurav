var num = 5;

while(num>5)
{
    console.log("this is while loop");
}

do
{
    console.log("this is do while");
}while(num>5);

for(var i=1;i<=10;i++)
{
    if(i%5==0)
    {
        console.log("this is multiple of 5:");
        break;
    }
    else{
        
        console.log("continue keyword:");
        continue;
        console.log("this ill not be execute");

    }
}
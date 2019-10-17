function display(id:number,name:string,mail_id?:string)
{
    console.log("idm is :"+id);
    console.log("name is :"+name);

    if(mail_id == undefined)
    {
        console.log("Email Id",mail_id); 
    }
}
display(12548,"Gaurav");
display(2154487,"Raghav","gauravmishra590@gmail.com");
class Employee
{
    empName : string;
    empCode : number;

    constructor(code : number,name : string)
    {
        this.empName = name;
        this.empCode = code;

        console.log("id is:"+this.empCode+" name is  :"+this.empName);
    }
}
var emp = new Employee( 1000,"hello");

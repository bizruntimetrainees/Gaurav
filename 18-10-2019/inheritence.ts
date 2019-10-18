class Inheritance
{
    name : string;

    constructor(name : string)
    {
        this.name = name;
    }
}
class TestInheritance extends Inheritance
{
      empid : number;

      constructor(empid : number,name:string)
      {
          super(name);
          this.empid = empid;
      }
      display(): void{
          console.log("id is :"+this.empid+" name is:"+this.name);
      }
}
var sho = new TestInheritance(101,"Gaurav");

sho.display();
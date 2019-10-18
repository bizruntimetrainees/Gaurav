class Person {
    name: string;
}

interface IEmployee extends Person { 
    empCode: number;
}

let ploy : IEmployee = { empCode  : 1, name:"James Bond" }
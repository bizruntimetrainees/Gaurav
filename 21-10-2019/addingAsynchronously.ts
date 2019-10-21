import{Observable} from 'rxjs'

const func = new Observable(Subscriber=>
    {
       Subscriber.next("hi");
       Subscriber.next("hello");
       Subscriber.next("gud");
       Subscriber.next("morning");
       setTimeout(() => {
           Subscriber.next(300);
       }, 1000);
    });

    console.log("before asynchronous..");

    func.subscribe(x =>
        {
            console.log(x);
        });
        console.log("successfully Added...");
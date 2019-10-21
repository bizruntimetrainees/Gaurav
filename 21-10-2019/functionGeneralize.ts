import {Observable, Subscriber} from 'rxjs'

const func = new Observable(Subscriber =>
    {
        console.log("Hello");
        Subscriber.next(100);
    });

    func.subscribe( x=>
        {
           console.log(x);
        });

    func.subscribe(y=>
        {
            console.log(y);
        });
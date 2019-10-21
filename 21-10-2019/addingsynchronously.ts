import {Observable, Subscriber} from 'rxjs'

const func = new Observable(Subscriber =>
    {
        Subscriber.next("Gaurav");
        Subscriber.next(21);
        Subscriber.next(1254.21);
        Subscriber.next(0.2154);
        Subscriber.next(true);
    });

    func.subscribe(x=>
        {
           console.log(x);
        })
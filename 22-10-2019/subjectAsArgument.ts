import {Subject, from} from 'rxjs'

const subject = new Subject<number>();

subject.subscribe({
    next : (v) => console.log(`observerA : ${v}`)
});
subject.subscribe({
    next : (v) => console.log(`observerB : ${v}`)
});

const observable = from([21,24,54]);

observable.subscribe(subject);
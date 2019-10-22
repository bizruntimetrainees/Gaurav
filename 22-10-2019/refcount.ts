import {interval,Subject} from 'rxjs'
import {multicast,refCount} from 'rxjs/operators'

const source = interval(500);
const subject = new Subject();
const refCounted = source.pipe(multicast(subject) ,refCount());

var  subscription1 ,subscription2;

console.log("observerA subscribe");

subscription1 = refCounted.subscribe({
    next: (v) => 
    console.log(`obseverA: ${v} `)
});
setTimeout(() => {
    console.log('observerB subscribed');
    subscription2 = refCounted.subscribe({
      next: (v) => console.log(`observerB: ${v}`)
    });
  }, 600);

setTimeout(() => {
    console.log("observerA is unsubscribed..");
    subscription1.unsubscribe();
}, 1000);

setTimeout(() => {
    console.log("observerB is unsubscribed..");
    subscription2.unsubscribe();
}, 2000);


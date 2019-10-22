import { from, Subject, ConnectableObservable } from 'rxjs';
import { multicast } from 'rxjs/operators';

const source = from([1, 2, 3]);
const subject = new Subject();
 var multicasted = source.pipe(multicast(subject)) as ConnectableObservable<any>
  

multicasted.subscribe({
  next: (v) => console.log(`observerA: ${v}`)
});
multicasted.subscribe({
  next: (v) => console.log(`observerB: ${v}`)
});
 

multicasted.connect();
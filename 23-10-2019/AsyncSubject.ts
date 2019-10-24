import {AsyncSubject} from 'rxjs'

var subject = new AsyncSubject();

subject.subscribe({
next : (v) => console.log(`observerA ${v}`)
});
 subject.next("hello");
 subject.next("Gaurav");
 subject.next("Mishra");
 subject.next(54);
 subject.next(true);
 subject.next(50.24);

 subject.subscribe({
     next : (v) => console.log(`observerB ${v}`)
 });

 subject.next(10000);
 subject.complete();

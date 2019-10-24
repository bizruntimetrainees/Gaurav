import { Observable, asyncScheduler } from 'rxjs';
import { observeOn } from 'rxjs/operators';

 
const observable = new Observable((proxyobserver) => {
    proxyobserver.next(1);
    proxyobserver.next(2);
    proxyobserver.next(3);
    proxyobserver.complete();
}).pipe(
  observeOn(asyncScheduler)
);
 
var finalObserver = {

  next(x) {
    console.log('got value ' + x)
  },
  error(err) {
    console.error('something wrong occurred: ' + err);
  },
  complete() {
     console.log('done');
  }
};
console.log('just before subscribe');
observable.subscribe(finalObserver);
console.log('just after subscribe');

const proxyObserver = {
    next(val) {
      asyncScheduler.schedule(
        (x) => finalObserver.next(x),
        0 ,
        val 
      );
    },
  
    
  }
    

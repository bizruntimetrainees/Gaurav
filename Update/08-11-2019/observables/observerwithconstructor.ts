import {Observable} from 'rxjs'
function sequenceSubscriber(observer) {
  
  observer.next(1);
  observer.next(2);
  observer.next(3);
  observer.complete();
}
const sequence = new Observable(sequenceSubscriber);

sequence.subscribe({
  next(num) { console.log(num); },
  complete() { console.log('Finished sequence'); }
});
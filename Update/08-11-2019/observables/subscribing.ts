import {Observable} from  'rxjs'
import {of } from  'rxjs'

const myObservable = of(1, 2, 3);


const myObserver = {
  next: x => console.log('Observer got a next value: ' + x),
  error: err => console.error('Observer got an error: ' + err),
  complete: () => console.log('Observer got a complete notification'),
};
myObservable.subscribe(myObserver);
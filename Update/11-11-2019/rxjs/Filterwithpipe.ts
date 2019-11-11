import { filter, map } from 'rxjs/operators';
import {of} from 'rxjs'

const squareOdd = of(1, 2, 3, 4, 5)
  .pipe(
    filter(n => n % 2 !== 0),
    map(n => n * n)
  );


squareOdd.subscribe(x => console.log(x));
import { Component, OnInit } from '@angular/core';
import {First} from '../First';


@Component({
  selector: 'first-app',
  templateUrl: './first-app.component.html',
  styleUrls: ['./first-app.component.css']
})
export class FirstAppComponent implements OnInit {

  First : First={
      id:undefined,
      name:''

  };

  
  
  ngOnInit() {
  }

  
}

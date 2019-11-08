import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-date-picker',
  templateUrl: './date-picker.component.html',
  styleUrls: ['./date-picker.component.css']
})
export class DatePickerComponent implements OnInit {
 
   minDate = new Date(1990,0,1);
   maxDate = new Date(2050,0,1);
  constructor() { }

  ngOnInit() {
  }

}

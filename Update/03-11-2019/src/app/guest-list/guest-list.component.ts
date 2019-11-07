import { Component, OnInit } from '@angular/core';
import { Guests } from '../GuestList';
import {First} from '../First';

@Component({
  selector: 'guest-list',
  templateUrl: './guest-list.component.html',
  styleUrls: ['./guest-list.component.css']
})
export class GuestListComponent implements OnInit {
  First1 = Guests;
  selectedGuest: First;
onSelect(First: First): void {
  this.selectedGuest = First;
}
 
  constructor() { }

  ngOnInit() {
  }

}

import {COMMA, ENTER} from '@angular/cdk/keycodes';
import {Component} from '@angular/core';
import {MatChipInputEvent} from '@angular/material/chips';
import { findSafariExecutable } from 'selenium-webdriver/safari';

export interface Name{
      
  name : string;
}

@Component({
  selector: 'app-buttons',
  templateUrl: './buttons.component.html',
  styleUrls: ['./buttons.component.css']
})
export class ButtonsComponent  {

  visible = true;
  selectable = true;
  removable = true;
  addOnBlur = true;
  readonly separatorKeysCodes: number[] = [ENTER, COMMA];
  names: Name[] = [
    {name: 'Rohit'},
    {name: 'Raghav'},
    {name: 'Soham'},
  ];

  add(event: MatChipInputEvent): void {
    const input = event.input;
    const value = event.value;

    // Add our fruit
    if ((value || '').trim()) {
      this.names.push({name: value.trim()});
    }

    // Reset the input value
    if (input) {
      input.value = '';
    }
  }

  remove(nAme: Name): void {
    const index = this.names.indexOf(nAme);

    if (index >= 0) {
      this.names.splice(index, 1);
    }
  }
}


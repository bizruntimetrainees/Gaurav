import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-forms-exmaple',
  templateUrl: './forms-exmaple.component.html',
  styleUrls: ['./forms-exmaple.component.css']
})
export class FormsExmapleComponent {

  name = new FormControl('');

  updateName() {
    this.name.setValue('Kajal');
  }
}

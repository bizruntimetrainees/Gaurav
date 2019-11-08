import { Component, OnInit } from '@angular/core';
import {FormBuilder,FormGroup, FormControl, Validators} from '@angular/forms'

@Component({
  selector: 'app-form-field',
  templateUrl: './form-field.component.html',
  styleUrls: ['./form-field.component.css']
})
export class FormFieldComponent  {
 
  options : FormGroup;
  constructor(fb : FormBuilder) 
  { 
     this.options = fb.group({
       hideRequired : false,
       floatLabel : 'auto',
       color : 'primary',
       fontSize :[16,Validators.min(10)],
     });
  }

  email = new FormControl('', [Validators.required, Validators.email]);

  getErrorMessage() {
    return this.email.hasError('required') ? 'You must enter a value' :
        this.email.hasError('email') ? 'Not a valid email' :
            '';
  }
  hide=true;
  getFontSize() {
    return Math.max(10, this.options.value.fontSize);
  }

}

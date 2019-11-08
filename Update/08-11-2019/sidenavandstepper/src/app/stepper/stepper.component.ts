import { Component, OnInit } from '@angular/core';
import {FormGroup,FormBuilder,Validators} from '@angular/forms'

@Component({
  selector: 'app-stepper',
  templateUrl: './stepper.component.html',
  styleUrls: ['./stepper.component.css']
})
export class StepperComponent implements OnInit {

   isLinear = false;
   firstformgroup :FormGroup;
   secondformgroup : FormGroup

  constructor(private _formbuilder : FormBuilder) { }

  ngOnInit()
   {
     this.firstformgroup = this._formbuilder.group({
      firstCtrl : ['', Validators.required]
     });
     this.secondformgroup = this._formbuilder.group({
      secondCtrl : ['',Validators.required]
     });
  }

}

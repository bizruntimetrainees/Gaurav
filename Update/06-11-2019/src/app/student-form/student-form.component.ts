import { Component, OnInit } from '@angular/core';
import {Student} from '../student'

@Component({
  selector: 'app-student-form',
  templateUrl: './student-form.component.html',
  styleUrls: ['./student-form.component.css']
})
export class StudentFormComponent  {

   cities  = ['Bhopal','Indore','Delhi','Mumbai','Bangalore'];

   model = new Student(224683,'Gaurav','Morena','MP');
   
   submitted = false;

   onsubmit()
   {
     this.submitted = true;
   }
  
   get diagnostic() 
   {
     return JSON.stringify(this.model);
   }
   newStudent()
   {
     this.model = new Student(224685,'','','');
   }
   
}

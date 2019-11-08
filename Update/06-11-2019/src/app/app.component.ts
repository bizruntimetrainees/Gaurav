import { Component } from '@angular/core';
import { QuestionControlService } from './question-control.service';
import {QuestionService}  from './question.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers : [QuestionControlService,QuestionService]
})
export class AppComponent {
  
  questions: any[];

  constructor(service: QuestionService) {
    this.questions = service.getQuestions();
  }
}

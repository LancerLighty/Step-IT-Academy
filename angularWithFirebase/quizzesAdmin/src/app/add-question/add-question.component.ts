import { Component, Input, OnInit } from '@angular/core';
import { Answer } from '../answer.model';
import { InfoService } from '../info/info.service';
import { Questions } from '../questions.model';
import { Quizzes } from '../quizzes.model';

@Component({
  selector: 'app-add-question',
  templateUrl: './add-question.component.html',
  styleUrls: ['./add-question.component.css']
})
export class AddQuestionComponent implements OnInit {
  newArr:any;
  arr: any[] = [];
  @Input()
  subid:any = {};
  constructor (private dtshr:InfoService) { }
  myQuiz:Quizzes = new Quizzes();
  myAnswer1:Answer = new Answer();
  myAnswer2:Answer = new Answer();
  myAnswer3:Answer = new Answer();
  myQuestion:Questions = new Questions();
  ngOnInit(): void {
    this.dtshr.getQuiz().subscribe((data:any) => {
      this.arr = data.docs.map((x: any) => {
        const dt = x.data();
        dt.id = x.id;
        return dt;
      });
      this.newArr = this.arr.filter(i=> i.subjectName == this.subid.codename)[0].questions
      console.log(this.newArr)
    })
    
  }
  delete(){
    // this.dtshr.deleteQuiz()
  }
  addQuestion(){
    this.myQuestion.subjectId =this.subid.codeid
    let currentSubject = this.arr.filter(i=> i.id == this.myQuestion.subjectId)[0]
    let crsbj = Object.assign({}, currentSubject)
    let randId = Math.random()*9999999999999
    console.log(this.myQuestion)
    let myqs = Object.assign({},this.myQuestion)
    myqs.id = randId
    let answ1 = Object.assign({},this.myAnswer1)
    let answ2 = Object.assign({},this.myAnswer2)
    let answ3 = Object.assign({},this.myAnswer3)
    this.myQuestion.answers.push(answ1,answ2,answ3)

   
    currentSubject.questions.push(myqs)
    this.myQuestion = new Questions()
    this.myAnswer1 = new Answer()
    this.myAnswer2 = new Answer()
    this.myAnswer3 = new Answer()

    console.log(crsbj)
    this.dtshr.updateQuiz(crsbj.id,crsbj)
  }
}

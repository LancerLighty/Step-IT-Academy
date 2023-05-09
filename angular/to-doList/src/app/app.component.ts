import { Component, Output } from '@angular/core';
import { Tasks } from './Tasks.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'to-doList';
  ToDoList:Tasks[] = [];
  toDo:number = 0
  inProgress:number = 0
  done:number = 0
  addNewTask(e:Tasks){
    this.ToDoList.push(e)
    if(e.status == "toDo"){
      this.toDo++
    } else if(e.status == "inProgress"){
      this.inProgress++
    } else {
      this.done++
    }
    console.log(this.ToDoList)
  }
  
}

import { Component, EventEmitter, Output } from '@angular/core';
import { Tasks } from '../Tasks.model';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent {
  newTask:Tasks = new Tasks();
  @Output()
  addTaskEmiter:EventEmitter<Tasks> = new EventEmitter();
  AddNewTask(){
      if(this.newTask.name != "" && this.newTask.status != ""){
        this.addTaskEmiter.emit(this.newTask)
        this.newTask = new Tasks();
      }
  }
}

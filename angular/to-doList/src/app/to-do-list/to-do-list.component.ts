import { Component, Input, OnInit } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { Tasks } from '../Tasks.model';

@Component({
  selector: 'app-to-do-list',
  templateUrl: './to-do-list.component.html',
  styleUrls: ['./to-do-list.component.css']
})
export class ToDoListComponent {
  constructor(private dtshr:DataSharingService){}
  @Input()
  getTask:Tasks = new Tasks();
  newStatus:string = ""
  arr:string[] = []
  changeStatus(){
    if(this.newStatus != ""){
      this.arr.push(this.newStatus)
      this.arr.push(this.getTask.status)
      this.dtshr.showTaskEmitter.emit(this.arr)
      this.arr = []
      this.getTask.status = this.newStatus;
    }
  }
}

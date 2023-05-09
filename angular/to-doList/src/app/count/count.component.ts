import { Component, Input, OnInit } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { Tasks } from '../Tasks.model';

@Component({
  selector: 'app-count',
  templateUrl: './count.component.html',
  styleUrls: ['./count.component.css']
})
export class CountComponent implements OnInit {
  constructor(private dtshr:DataSharingService){ }
  @Input() toDo:number = 0
  @Input() inProgress:number = 0
  @Input() done:number = 0
  ngOnInit(): void {
    this.dtshr.showTaskEmitter.subscribe((x:string[])=>{
      switch(x[0]) {
        case 'toDo':
          this.toDo++;
          break;
        case 'inProgress':
          this.inProgress++;
          break;
        case 'done':
          this.done++;
          break;
        default:
          // Handle unexpected input
          break;
      }
      switch(x[1]) {
        case 'toDo':
          this.toDo--;
          break;
        case 'inProgress':
          this.inProgress--;
          break;
        case 'done':
          this.done--;
          break;
        default:
          // Handle unexpected input
          break;
      }
    })
  }
}

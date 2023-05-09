import { Component, EventEmitter, Output } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private dtshr:DataSharingService){}
  newUser:User = new User()
  save(){
    this.dtshr.userEmitter.emit(this.newUser)
  }
  user:User[] = [
    new User("tekle", "mamporia"),
    new User("tekle1", "mamporia1"),
    new User("tekle2", "mamporia2"),
    new User("tekle3", "mamporia3"),
  ]
}

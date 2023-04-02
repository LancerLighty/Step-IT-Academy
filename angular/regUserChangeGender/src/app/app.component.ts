import { Component } from '@angular/core';
import { User } from './shared-models/User.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'idk';
  myUser:User = new User();
  arr:User[] = [];
  addUser(){
    this.arr.push(this.myUser)
    this.myUser = new User();
    console.log(this.arr)
  }
}

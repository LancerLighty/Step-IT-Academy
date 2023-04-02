import { Component, EventEmitter, Output } from '@angular/core';
import { User } from '../user.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  myUser:User = new User();
  @Output()
  addUserEmitter:EventEmitter<User> = new EventEmitter();
  save(){
      this.addUserEmitter.emit(this.myUser)
      this.myUser = new User()
  }
}
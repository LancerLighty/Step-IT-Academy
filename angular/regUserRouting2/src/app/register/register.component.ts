import { Component, Output } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  constructor(private dtshr:DataSharingService){}
  newUser:User = new User()
  regNewUser(){
    this.dtshr.users.push(this.newUser)
  }
}

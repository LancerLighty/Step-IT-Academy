import { Component, Output } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  constructor(private dtshr:DataSharingService){ }
  @Output()
  newUser:User =  new User();
  error:string = ""
  register(){
    if(this.newUser.fname != "" && this.newUser.lname != "" && this.newUser.email != ""){
      this.error = ""
      this.dtshr.userEmitter.emit(this.newUser)
      this.newUser =  new User();
    } else {
      this.error = "make shure you filled all inputs"
    }
  }
}

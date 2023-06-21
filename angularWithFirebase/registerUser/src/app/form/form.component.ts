import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';
import { DataSharingService } from '../data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent  implements OnInit {

  constructor (private dt:DataSharingService, private auth:AuthService) { }
  arr:any = []
  // newUser:User = new User
  email:string = ""
  password:string = ""
  ngOnInit(): void {
  }
  register:string = ""
  error:string = ""
  repeatPass:string = ""
  addUser(){
    // if(this.newUser.fname != "" && this.newUser.lname != "" && this.newUser.email != "" && this.newUser.password != "" && this.repeatPass == this.newUser.password){
      if(this.email != "" && this.password != ""){
      // this.dt.addUser(this.newUser)
      this.auth.register(this.email, this.password)
      this.error = ""
      this.register = "successfully registered!"
    } else {
      this.error = "make sure you filled everything corectry"
    }
  }

}

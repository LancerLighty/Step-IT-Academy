import { Component, OnInit } from '@angular/core';
import { DataSharingService } from '../data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent  implements OnInit {

  constructor (private dt:DataSharingService) { }
  arr:any = []
  newUser:User = new User
  ngOnInit(): void {
  }
  register:string = ""
  error:string = ""
  repeatPass:string = ""
  addUser(){
    if(this.newUser.fname != "" && this.newUser.lname != "" && this.newUser.email != "" && this.newUser.password != "" && this.repeatPass == this.newUser.password){
      this.dt.addUser(this.newUser)
      this.error = ""
      this.register = "successfully registered!"
    } else {
      this.error = "make sure you filled everything corectry"
    }
  }

}

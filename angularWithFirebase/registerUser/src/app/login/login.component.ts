import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private auth:AuthService) { }

  ngOnInit(): void {
  }
  email:string = ""
  password:string = ""
  logIn(){
    if(this.email != "" && this.password != ""){
      this.auth.login(this.email, this.password)
      this.email = ""
      this.password = ""
    } else {
      alert("please enter email and password")
    }
  }
  signInWithGoogle(){
      this.auth.googleSignIn()
  }
}

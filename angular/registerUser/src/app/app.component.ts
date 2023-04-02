import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularTest';
  email = "";
  Password = "";
  age = "";
  RepeatPassword = "";
  arr:any[] =[]
  save(){
    if(this.Password == this.RepeatPassword && this.email.indexOf("@") != -1 && this.Password.length > 7){
      var obj= {
        email: "",
        password: "",
        age: ""
      }
      obj.email = this.email;
      obj.password = this.Password;
      obj.age = this.age;
      this.arr.push(obj)
      console.log(this.arr)
    }
  }
  sorting = ""
  sort(){
    if(this.sorting == "zrdadobit"){
      this.arr = this.arr.sort(function(a, b){return a.age - b.age})
    } else if(this.sorting == "klebadobit") {
      this.arr = this.arr.sort(function(a, b){return b.age - a.age})
    }
  }
}

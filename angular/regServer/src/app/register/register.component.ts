import { Component, EventEmitter, Output } from '@angular/core';
import { Server } from '../server.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  error:string = ""
  newServer:Server = new Server();
  @Output()
  addServerEmitter:EventEmitter<Server> = new EventEmitter();
  register(){
    if(this.newServer.status != "" && this.newServer.name != "" && this.newServer.pay != ""){
      this.addServerEmitter.emit(this.newServer)
      console.log(this.newServer)
      this.newServer = new Server()
    } else {
      this.error = "make sure you filled all inputs"
    }
  }
}


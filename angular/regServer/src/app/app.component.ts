import { Component } from '@angular/core';
import { Server } from './server.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'regServer';
  servers:Server[] = []
  addNewServer(newServer:Server){
    this.servers.push(newServer)
    console.log(this.servers)
    console.log("test")
  }
}

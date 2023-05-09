import { Component } from '@angular/core';
import { User } from '../user.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  arr:User[] = [
    new User("tekle", "mamporia", "tekle@gmail.com"),
    new User("tekle1", "mamporia1", "tekle1@gmail.com"),
    new User("tekle2", "mamporia2", "tekle2@gmail.com")
  ]
}

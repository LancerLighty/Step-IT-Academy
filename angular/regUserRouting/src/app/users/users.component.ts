import { Component, Input } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent {
  constructor(private dtshr:DataSharingService){ }
  usersInfo:User[] = [];
  ngOnInit(): void {
    this.dtshr.usersEmitter.subscribe((users:User[])=>{
      console.log('Users received:', users);
      this.usersInfo = users
    })
  }
  
}

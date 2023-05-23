import { Component, OnInit } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit{
  constructor(private dtshr:DataSharingService){}
  ngOnInit(): void {
    this.usersInfo = this.dtshr.returnArr()
    console.log(this.usersInfo)
  }
  usersInfo:User[] = []
}

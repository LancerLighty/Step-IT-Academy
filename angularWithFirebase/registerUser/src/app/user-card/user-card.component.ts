import { Component, Input, OnInit } from '@angular/core';
import { DataSharingService } from '../data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-user-card',
  templateUrl: './user-card.component.html',
  styleUrls: ['./user-card.component.css']
})
export class UserCardComponent implements OnInit {

  constructor (private dt:DataSharingService) { }
  @Input()
  user:User = new User()
  ngOnInit(): void {
  }
  deleteUser(user:User){
    if(window.confirm("are you sure you want to delete?")){
      this.dt.deleteUser(user.id)
      console.log(user.id)
    }
  }
  updateUser(user:User){
    if(window.confirm("are you sure you want to update?")){
      this.dt.updateUser(user)
      console.log(user.id)
    }
  }

}

import { Component, Output } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent {
  constructor(private dtshr:DataSharingService){ }
  userInfo:User = new User()
  users:User[] = []
  ngOnInit(): void {
    this.dtshr.userEmitter.subscribe((x:User)=>{
      this.userInfo = x
      this.users.push(this.userInfo)
      console.log(this.users)
    })
  }
  @Output()
  getUserInfo(){
    this.dtshr.usersEmitter.emit(this.users)
  }
}

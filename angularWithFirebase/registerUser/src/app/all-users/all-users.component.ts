import { Component, Input, OnInit } from '@angular/core';
import { DataSharingService } from '../data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-all-users',
  templateUrl: './all-users.component.html',
  styleUrls: ['./all-users.component.css']
})
export class AllUsersComponent implements OnInit {

  constructor (private dt:DataSharingService) { }
  @Input()
  users:User[] = []
  ngOnInit(): void {
    this.dt.getAllUsers().subscribe((data:any) =>{
      this.users = data.map((e:any)=>{ 
        const dt = e.payload.doc.data() 
        data.id = e.payload.doc.id
        return dt
      })
    })
  }

}

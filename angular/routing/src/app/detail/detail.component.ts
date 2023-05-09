import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { User } from '../user.model';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit {
  constructor(private actroute:ActivatedRoute) { }
  myuser:User = new User();
  email:string = ""
  ngOnInit(): void {
    //snapshot only works shen we refresh
    // this.email = this.actroute.snapshot.params['email']
    // this.myuser = this.actroute.snapshot.params as User;
    // console.log(this.email)
    // console.log(this.myuser)
    this.actroute.params.subscribe((par:Params)=>{
      this.myuser = par as User;
    })
  }
}

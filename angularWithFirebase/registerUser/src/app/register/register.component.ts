import { Component, OnInit } from '@angular/core';
import { DataSharingService } from '../data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor (private dt:DataSharingService) { }
  ngOnInit(): void {
  }

}

import { Component, Input } from '@angular/core';
import { DataSharingService } from '../services/data-sharing.service';
import { User } from '../user.model';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})
export class ModalComponent {
  constructor(private dtshr:DataSharingService){}
  @Input()
  user:User = new User()
  ngOnInit():void {
    this.dtshr.userEmitter.subscribe((newUser:User)=> {
      this.user = newUser;
    })
  }
}

import { Component, Input } from '@angular/core';
import { User } from '../user.model';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
  @Input()
  info:User = new User();
  
}

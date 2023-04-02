import { Component, Input } from '@angular/core';
import { Server } from '../server.model';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
  @Input()
  getServer:Server = new Server();
}

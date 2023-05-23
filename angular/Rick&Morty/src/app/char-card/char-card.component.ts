import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-char-card',
  templateUrl: './char-card.component.html',
  styleUrls: ['./char-card.component.css']
})
export class CharCardComponent {
  @Input()
  char:any = {}
}

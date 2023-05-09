import { HttpClient } from '@angular/common/http';
import { Component, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-char-card',
  templateUrl: './char-card.component.html',
  styleUrls: ['./char-card.component.css']
})
export class CharCardComponent {
  constructor(private http:HttpClient, private actroute:ActivatedRoute){ }
  @Input()
  char:any = {}
}

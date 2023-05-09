import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-req-card',
  templateUrl: './req-card.component.html',
  styleUrls: ['./req-card.component.css']
})
export class ReqCardComponent {
  @Input()
  info:any = {}
  @Input()
  nameS:string = ""
  @Input()
  genderS:string =""
}

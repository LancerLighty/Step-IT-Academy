import { HttpClient } from '@angular/common/http';
import { Component, Input } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-ep-card',
  templateUrl: './ep-card.component.html',
  styleUrls: ['./ep-card.component.css']
})
export class EpCardComponent {
  constructor(private http:HttpClient, private actroute:ActivatedRoute){ }
  @Input()
  info:any = {}
  characters:any = []
  ngOnInit():void {
    for(let i of this.info.episode){
      this.http.get(i)
      .subscribe((x:any)=>{
        this.characters.push(x)
      })
    }
  }
}

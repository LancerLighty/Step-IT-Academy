import { HttpClient } from '@angular/common/http';
import { Input } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-ep-card',
  templateUrl: './ep-card.component.html',
  styleUrls: ['./ep-card.component.css']
})
export class EpCardComponent implements OnInit {
  @Input()
  info:any = {}
  characters:any = []
  constructor(private http:HttpClient, private actroute:ActivatedRoute) { }

  ngOnInit(): void {
    for(let i of this.info.episode){
      this.http.get(i)
      .subscribe((x:any)=> {
        this.characters.push(x)
      })
    }
  }

}

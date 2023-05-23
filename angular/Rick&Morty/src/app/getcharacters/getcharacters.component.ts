import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-getcharacters',
  templateUrl: './getcharacters.component.html',
  styleUrls: ['./getcharacters.component.css']
})
export class GetcharactersComponent implements OnInit{
  constructor(private http:HttpClient, private actroute:ActivatedRoute) { }
  @Input()
  info:any = {}
  charactersEp:any[] = []
  characters:any = []
  ngOnInit(): void {
    console.log(this.info)
    this.http.get(this.info.episode)
    .subscribe((x:any)=> {
      this.charactersEp = x.characters
      for(let i of this.charactersEp){
        this.http.get(i)
        .subscribe((x:any)=> {
          this.characters.push(x)
        })
      }
    })
  }

}

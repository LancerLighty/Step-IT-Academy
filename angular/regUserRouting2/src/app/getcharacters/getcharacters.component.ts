import { HttpClient } from '@angular/common/http';
import { Component, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-getcharacters',
  templateUrl: './getcharacters.component.html',
  styleUrls: ['./getcharacters.component.css']
})
export class GetcharactersComponent {
  constructor(private http:HttpClient, private actroute:ActivatedRoute){ }
  @Input()
  info:any = {}
  charactersEp:any[] = []
  characters:any = []
  ngOnInit():void {
    console.log(this.info)
    // let arr = info.split(/(\d+)/).filter(Boolean);
    // console.log(arr);
    this.http.get(this.info.episode)
      .subscribe((x:any)=> {
        this.charactersEp = x.characters
        console.log(this.charactersEp)
        for(let i of this.charactersEp){
          this.http.get(i)
          .subscribe((x:any)=> {
            this.characters.push(x)
          })
        }
    })
  }
}

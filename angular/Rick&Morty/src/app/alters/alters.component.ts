import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { User } from '../user.model';
@Component({
  selector: 'app-alters',
  templateUrl: './alters.component.html',
  styleUrls: ['./alters.component.css']
})
export class AltersComponent  implements OnInit{
  constructor(private http:HttpClient, private actroute:ActivatedRoute){ }
  character:any = {}
  characters:any = []
  ngOnInit():void {
    this.actroute.params.subscribe((par:Params)=> {
      this.character = par
      console.log(this.character)
      let name = this.character.name.slice(0, this.character.name.indexOf(" "))
      console.log(name)
      this.http.get(`https://rickandmortyapi.com/api/character/?name=${name}&status=${this.character.status}`)
      .subscribe((characters:any)=> {
        this.characters = characters.results
        console.log(this.characters)
      })
    })
  }
}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
@Component({
  selector: 'app-episodes',
  templateUrl: './episodes.component.html',
  styleUrls: ['./episodes.component.css']
})
export class EpisodesComponent implements OnInit {

  constructor(private http:HttpClient, private actroute:ActivatedRoute) { }
  info:any[] = []
  character:any = {}
  characters:any=[]
  ngOnInit(): void {
    this.actroute.params.subscribe((par:Params)=> {
      this.character = par
      this.http.get(`https://rickandmortyapi.com/api/character/?name=${this.character.name}&status=${this.character.status}`)
      .subscribe((x:any)=>{
        this.info = [].concat(x.results)
        console.log(this.info)
      })
    })
  }

}

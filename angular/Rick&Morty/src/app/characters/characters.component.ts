import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-characters',
  templateUrl: './characters.component.html',
  styleUrls: ['./characters.component.css']
})
export class CharactersComponent implements OnInit {

  constructor(private http:HttpClient, private actroute:ActivatedRoute) { }
  info:any = []
  ep:any = {}
  episode:any = ""
  ngOnInit(): void {
    this.actroute.params.subscribe((par:Params)=> {
      this.ep = par
      this.http.get(this.ep.episode)
      .subscribe((x:any)=> {
        this.info = x.characters
      })
    })
  }

}

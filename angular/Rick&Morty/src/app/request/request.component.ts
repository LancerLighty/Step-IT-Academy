import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-request',
  templateUrl: './request.component.html',
  styleUrls: ['./request.component.css']
})
export class RequestComponent implements OnInit{
  constructor(private http:HttpClient){ }
  results:any[] = []
  // first:any = {}
  // second:any = {}
  // third:any = {}
  sliderArr:any[] =[]
  constArr:any[] =[]
  ngOnInit(): void {
    this.http.get('https://rickandmortyapi.com/api/character')
    .subscribe((x:any)=>{
      this.results = [].concat(x.results)
      this.constArr = [].concat(x.results)
      console.log(this.results)
      // this.function()
      let rand = Math.floor(Math.random() * (x.results.length-3))
      this.sliderArr = x.results.splice(rand,3)
    })
  }
  name:string = ""
  gender:string = ""
  onSearchValues(searchValues: { name: string, gender: string }) {
    this.name = searchValues.name;
    this.gender = searchValues.gender;
  } 
  // function(){
  //   const randomIndexes:number[] = [];
  //   while (randomIndexes.length < 3) {
  //     const index = Math.floor(Math.random() * 19);
  //     if (!randomIndexes.includes(index)) {
  //       randomIndexes.push(index);
  //     }
  //   }
  //   //Use the random indexes to set the first, second, and third properties
  //   this.first = this.results[randomIndexes[0]];
  //   this.second = this.results[randomIndexes[1]];
  //   this.third = this.results[randomIndexes[2]];
  // }
}

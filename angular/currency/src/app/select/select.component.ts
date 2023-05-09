import { HttpClient } from '@angular/common/http';
import { Component, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.css']
})
export class SelectComponent {
  constructor(private http:HttpClient, private actroute:ActivatedRoute){ }
  all:any = []
  ngOnInit():void {
    this.http.get('https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/usd.json')
    .subscribe((x:any)=> {
      this.all = Object.keys(x.usd)
      console.log(this.all)
    })
  }
  options:any = {
    from: "",
    to: "",
    amount: ""
  }
  new:number = 0;
  result:number = 0
  change(){
    console.log(this.options)
    this.http.get(`https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/${this.options.from}.json`)
    .subscribe((x:any)=> {
      let save = x[this.options.from]
      console.log(save)
      for(var i of Object.keys(save)){
        if(i == this.options.to){
          this.new = save[i]
          this.result = this.options.amount * this.new
          break;
        }
      }
    })
  }
}

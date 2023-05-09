import { Component } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-iner',
  templateUrl: './iner.component.html',
  styleUrls: ['./iner.component.css']
})
export class InerComponent {
  constructor(private actroute:ActivatedRoute) {}
  user:any = {}
  ngOnInit():void {
      // this.actroute.params.subscribe((par:Params)=> {
      //   this.user = par
      //   console.log(this.user)
      // })
      this.user = this.actroute.snapshot.params
      console.log(this.user)      
  }
}

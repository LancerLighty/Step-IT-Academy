import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent  {
  @Input() 
  result:any[] = [12,"sg"]
  // @Input() 
  // first:any = {}
  // @Input()
  // second:any = {}
  // @Input()
  // third:any = {}
  
  // ngOnChanges(): void {

  //   // Generate three random indexes
  //   const randomIndexes:number[] = [];
  //   while (randomIndexes.length < 3) {
  //     const index = Math.floor(Math.random() * 19);
  //     if (!randomIndexes.includes(index)) {
  //       randomIndexes.push(index);
  //     }
  //   }
  //   //Use the random indexes to set the first, second, and third properties
  //   this.first = this.result[randomIndexes[0]].image;
  //   this.second = this.result[randomIndexes[1]].image;
  //   this.third = this.result[randomIndexes[2]].image;
  //   console.log(this.result)
  // }
}

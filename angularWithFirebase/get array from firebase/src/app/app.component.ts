import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'fire';
  arr:any[] = []
  constructor(private dt:DataService){}
  ngOnInit(): void {
    this.dt.getAllUsers().subscribe((data:any)=>{
      this.arr = data.map((e:any)=>{
        const dt = e.payload.doc.data()
        data.id = e.payload.doc.id
        console.log(dt)
        return dt;

      })
    })
  }
   
}

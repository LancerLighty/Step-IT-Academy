import { EventEmitter, Injectable, Output } from '@angular/core';
import { Tasks } from '../Tasks.model';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {

  constructor() { }
  @Output()
  showTaskEmitter:EventEmitter<string[]> = new EventEmitter();
}

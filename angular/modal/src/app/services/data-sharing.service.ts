import { EventEmitter, Injectable, Output } from '@angular/core';
import { User } from '../user.model';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {

  constructor() { }
  @Output()
  userEmitter:EventEmitter<User> = new EventEmitter();
}

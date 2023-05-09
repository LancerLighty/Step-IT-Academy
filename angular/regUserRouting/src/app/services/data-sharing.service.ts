import { EventEmitter, Injectable, Output } from '@angular/core';
import { User } from '../user.model';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {
  showServerEmitter: any;

  constructor() { }
  @Output()
  userEmitter:EventEmitter<User> = new EventEmitter();
  @Output()
  usersEmitter:EventEmitter<User[]> = new EventEmitter();
}

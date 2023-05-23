import { Injectable } from '@angular/core';
import { User } from '../user.model';

@Injectable({
  providedIn: 'root'
})
export class DataSharingService {

  constructor() { }
  users:User[] = [];
  returnArr(){
    return this.users;
  }
}

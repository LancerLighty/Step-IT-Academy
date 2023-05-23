import { Injectable } from '@angular/core';
import {AngularFirestore} from '@angular/fire/compat/firestore'
import { User } from './user.model';
@Injectable({
  providedIn: 'root'
})
export class DataSharingService {

  constructor(private fs:AngularFirestore) { }
  getAllUsers(){
    return this.fs.collection('/users').snapshotChanges()
  }
  addUser(user:User){
    const userObject = user['toObject']()
    userObject.id = this.fs.createId();
    return this.fs.collection('/users').add(userObject);
  }
}

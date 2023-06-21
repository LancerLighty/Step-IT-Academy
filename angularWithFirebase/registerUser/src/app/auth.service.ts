import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { Router } from '@angular/router';
import { GoogleAuthProvider, GithubAuthProvider, FacebookAuthProvider } from '@angular/fire/auth'
@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private fireauth: AngularFireAuth, private router: Router) { }
  login(email:string, password :string){
    this.fireauth.signInWithEmailAndPassword(email, password).then(res => {
      localStorage.setItem('token', 'true');
      alert("login was succesfull")
      // this.router.navigate(['AllUsers']);
      if(res.user?.emailVerified == true){
        alert("email was verified succesfully")
      } else {
        this.router.navigate(['/verify-email']);
      }
    }, err => {
      alert("something's went wrong")
      this.router.navigate(['/login'])
    })
  }
  register(email: string,password :string){
      email += "@gmail.com"
      this.fireauth.createUserWithEmailAndPassword(email, password).then(res => {
        alert("registration was succesfull")
        this.router.navigate(['/login'])
        this.sendEmailForVerification(res.user)
      }, err => {
        alert(err.message)
      })
  }
  logout() {
    this.fireauth.signOut().then( () => {
      localStorage.removeItem('token')
      this.router.navigate(['/login'])
    }, err => {
      alert(err.message)
    })
  }

  forgotPassword(email:string){
    this.fireauth.sendPasswordResetEmail(email).then(() => {
      this.router.navigate(['/verify-email'])
    }, err => {
      alert(err.message)
    })
  }
  sendEmailForVerification(user : any){
    user.sendEmailVerification().then((res :any) => {
      this.router.navigate(['/verify-email']);
    }, (err : any) => {
      alert(err.message)
    })
  }
  googleSignIn(){
    return this.fireauth.signInWithPopup(new GoogleAuthProvider).then(res => {
      localStorage.setItem('token', JSON.stringify(res.user?.uid))
    }, (err:any) => {
      alert(err.message)
    })
  }
}

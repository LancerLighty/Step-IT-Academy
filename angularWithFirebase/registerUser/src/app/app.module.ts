import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {AngularFireModule} from '@angular/fire/compat'
import { environment } from 'src/environments/environment';
import { FormsModule } from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { AllUsersComponent } from './all-users/all-users.component';
import { UserCardComponent } from './user-card/user-card.component';
import { NavigationComponent } from './navigation/navigation.component';
import { LogoComponent } from './logo/logo.component';
import { FormComponent } from './form/form.component';
import { LoginComponent } from './login/login.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { VerifyEmailComponent } from './verify-email/verify-email.component';
import firebase from 'firebase/app';
import { firebaseConfig } from './firebase.config';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    AllUsersComponent,
    UserCardComponent,
    NavigationComponent,
    LogoComponent,
    FormComponent,
    LoginComponent,
    ForgotPasswordComponent,
    VerifyEmailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebase),
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { RegisterComponent } from './register/register.component';
import { UsersComponent } from './users/users.component';
import { CardComponent } from './card/card.component';
import { FormsModule } from '@angular/forms';
import { RequestComponent } from './request/request.component';

import { HttpClientModule } from '@angular/common/http';
import { ReqCardComponent } from './req-card/req-card.component';
import { CarouselComponent } from './carousel/carousel.component';
import { SearchComponent } from './search/search.component';
import { AltersComponent } from './alters/alters.component';
import { EpisodesComponent } from './episodes/episodes.component';
import { CharactersComponent } from './characters/characters.component';
import { EpCardComponent } from './ep-card/ep-card.component';
import { GetcharactersComponent } from './getcharacters/getcharacters.component';
import { CharCardComponent } from './char-card/char-card.component';
import { ErrorPageComponent } from './error-page/error-page.component';
@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    RegisterComponent,
    UsersComponent,
    CardComponent,
    RequestComponent,
    ReqCardComponent,
    CarouselComponent,
    SearchComponent,
    AltersComponent,
    EpisodesComponent,
    CharactersComponent,
    EpCardComponent,
    GetcharactersComponent,
    CharCardComponent,
    ErrorPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

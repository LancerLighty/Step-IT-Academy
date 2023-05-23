import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
// import { RouterModule, Routes } from '@angular/router';
import { AltersComponent } from './alters/alters.component';
import { CharactersComponent } from './characters/characters.component';
import { EpisodesComponent } from './episodes/episodes.component';
import { RegisterComponent } from './register/register.component';
import { RequestComponent } from './request/request.component';
import { UsersComponent } from './users/users.component';

const routes: Routes = [
  {path:'', component:RegisterComponent},
  {path:'users', component:UsersComponent},
  {path:'request', component:RequestComponent},
  {path:'alters/:name/:status', component:AltersComponent},
  {path:'episodes/:name/:status', component:EpisodesComponent},
  {path:'characters/:episode', component:CharactersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

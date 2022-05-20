import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { MusicAddComponent } from './components/music-add/music-add.component';

const routes: Routes = [
  {path:'home',component:HomeComponent},
  {path:'add',component:MusicAddComponent},
  {path:'',redirectTo:'home',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

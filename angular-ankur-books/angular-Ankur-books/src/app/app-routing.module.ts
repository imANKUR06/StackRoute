import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthenticationComponent } from './book/authentication/authentication.component';
import { BookAddComponent } from './book/book-add/book-add.component';
import { BookDeleteComponent } from './book/book-delete/book-delete.component';
import { BookEditComponent } from './book/book-edit/book-edit.component';
import { BookListComponent } from './book/bookList/bookList.component';
import { RegisterComponent } from './book/register/register.component';
import { SearchNameComponent } from './book/search-name/search-name.component';
import { AuthGuard } from './guard/auth.guard';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  {path:'register',component:RegisterComponent},
  {path:'login',component:AuthenticationComponent},
  {path:'home',component:HomeComponent,canActivate:[AuthGuard]},
  {path:'create',component:BookAddComponent,canActivate:[AuthGuard]},
  {path:'book',component:BookListComponent,canActivate:[AuthGuard]},
  {path:'edit/:id',component:BookEditComponent,canActivate:[AuthGuard]},
  {path:'song/:name',component:SearchNameComponent},
  {path:'delete/:id',component:BookDeleteComponent,canActivate:[AuthGuard]},
  {path:'',redirectTo:'login',pathMatch:'full'},
  {path:'**',component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

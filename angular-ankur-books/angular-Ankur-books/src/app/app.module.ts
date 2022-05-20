import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HeaderComponent } from './header/header.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BookListComponent } from './book/bookList/bookList.component';
import { BookComponent } from './book/book.component';
import { AuthenticationComponent } from './book/authentication/authentication.component';
import { TokenInterceptorService } from './Interceptors/tokenInterceptorService';
import { BookAddComponent } from './book/book-add/book-add.component';
import { RegisterComponent } from './book/register/register.component';
import { BookEditComponent } from './book/book-edit/book-edit.component';
import { BookDeleteComponent } from './book/book-delete/book-delete.component';
import { SearchNameComponent } from './book/search-name/search-name.component';

@NgModule({
  declarations: [
    AppComponent,
    
    HomeComponent,
    PageNotFoundComponent,
    HeaderComponent,
    BookComponent,
    BookListComponent,
    AuthenticationComponent,
    BookAddComponent,
    RegisterComponent,
    BookEditComponent,
    BookDeleteComponent,
    SearchNameComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptorService,
      multi:true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

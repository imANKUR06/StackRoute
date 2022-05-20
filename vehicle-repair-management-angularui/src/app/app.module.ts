import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';
import { AddVehicleComponent } from './components/vehicle-list/add-vehicle/add-vehicle.component';
import { EditVehicleComponent } from './components/vehicle-list/edit-vehicle/edit-vehicle.component';
import { DeleteVehicleComponent } from './components/vehicle-list/delete-vehicle/delete-vehicle.component';
import { HeaderComponent } from './components/header/header.component';
import { PageNotFoundComponent } from './components/pagenotfound/pagenotfound.component';
import { HomeComponent } from './components/home/home.component';
import { FormsModule } from '@angular/forms';
import { AboutUsComponent } from './components/about-us/about-us.component';
import { LoginComponent } from './components/authentication/login/login.component';
import { RegisterComponent } from './components/authentication/register/register.component';
import { TokenInterceptorService } from './interceptors/tokenInterceptorService';

@NgModule({
  declarations: [
    AppComponent,
    VehicleListComponent,
    AddVehicleComponent,
    EditVehicleComponent,
    DeleteVehicleComponent,
    HeaderComponent,
    PageNotFoundComponent,
    HomeComponent,
    AboutUsComponent,
    LoginComponent,
    RegisterComponent
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

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutUsComponent } from './components/about-us/about-us.component';
import { LoginComponent } from './components/authentication/login/login.component';
import { RegisterComponent } from './components/authentication/register/register.component';
import { HomeComponent } from './components/home/home.component';
import { PageNotFoundComponent } from './components/pagenotfound/pagenotfound.component';
import { AddVehicleComponent } from './components/vehicle-list/add-vehicle/add-vehicle.component';
import { DeleteVehicleComponent } from './components/vehicle-list/delete-vehicle/delete-vehicle.component';
import { EditVehicleComponent } from './components/vehicle-list/edit-vehicle/edit-vehicle.component';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'home', component: HomeComponent,canActivate:[AuthGuard]},
  { path: 'vehiclelist', component: VehicleListComponent,canActivate:[AuthGuard]},
  { path: 'addvehicle', component: AddVehicleComponent,canActivate:[AuthGuard]},
  { path: 'contactus', component: AboutUsComponent, canActivate:[AuthGuard]},
  { path: 'editvehicle/:id', component: EditVehicleComponent, canActivate:[AuthGuard] },
  { path: 'deletevehicle/:id', component: DeleteVehicleComponent, canActivate:[AuthGuard] },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

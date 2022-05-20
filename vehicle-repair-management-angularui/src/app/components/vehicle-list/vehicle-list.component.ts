import { Component, OnInit } from '@angular/core';
import { IVehicle } from 'src/app/models/vehicle/vehicle';
import { VehicleService } from 'src/app/services/vehicle/vehicle.service';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {


  isVehiclesAvailable: boolean = false;
  showVehicleDetails: boolean = true;
  searchName: string = '';
  searchId: string = '';
  vehicles: IVehicle[] = [];
  constructor(private _vehiclesService: VehicleService) {

  }

  ngOnInit(): void {
    this.findAll()
  }

  showHideVehicleDetails() {
    this.showVehicleDetails = !this.showVehicleDetails;
  }
  findById() {
    let id = parseInt(this.searchId);
    this._vehiclesService.getVehicleById(id)
      .subscribe((res: any) => {
        // console.log(res)
        if(res)
        this.vehicles = [res];
        else
        this.vehicles=[];
        if (this.vehicles.length == 0) {
          this.isVehiclesAvailable = false;
        }
        else {
          this.isVehiclesAvailable = true;
        }
      })
  }
  findByName() {

    this._vehiclesService.searchByName(this.searchName)
      .subscribe((res: any) => {
        // console.log(res);
        this.vehicles = res;
        if (this.vehicles.length == 0) {
          this.isVehiclesAvailable = false;
        }
        else {
          this.isVehiclesAvailable = true;
        }
      })
  }

  findAll(){
    this._vehiclesService.getVehicles()
      .subscribe((data: IVehicle[]) => {
        this.vehicles = data;
        if (this.vehicles.length == 0) {
          this.isVehiclesAvailable = false;
        }
        else {
          this.isVehiclesAvailable = true;
        }

      });
  }

}








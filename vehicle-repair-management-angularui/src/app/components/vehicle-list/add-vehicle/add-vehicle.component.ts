import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IVehicleData } from 'src/app/models/vehicle/vehicleData';
import { VehicleService } from 'src/app/services/vehicle/vehicle.service';

@Component({
  selector: 'app-add-vehicle',
  templateUrl: './add-vehicle.component.html',
  styleUrls: ['./add-vehicle.component.css']
})
export class AddVehicleComponent implements OnInit {

  constructor(private _vehicleService:VehicleService, private router:Router) { }

  ngOnInit(): void {
  }

  vehicleDetails:IVehicleData ={
    name:"",
    type:"",
    category:"",
    complaint:"",
    cost:0,
    username: ''+sessionStorage.getItem('username')
  }

  addVehicle(){
    // console.log(this.vehicleDetails);
    this._vehicleService.addVehicle(this.vehicleDetails)
    .subscribe(res =>{
      this.router.navigate(['/vehiclelist'])
    });
  }

}

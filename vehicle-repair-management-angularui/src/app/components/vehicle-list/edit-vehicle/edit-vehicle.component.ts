import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IVehicle } from 'src/app/models/vehicle/vehicle';
import { IEditVehicleData } from 'src/app/models/vehicle/vehicleData';
import { VehicleService } from 'src/app/services/vehicle/vehicle.service';

@Component({
  selector: 'app-edit-vehicle',
  templateUrl: './edit-vehicle.component.html',
  styleUrls: ['./edit-vehicle.component.css']
})
export class EditVehicleComponent implements OnInit {


  constructor(private _vehicleService: VehicleService,
    private router: Router, private activeRoute: ActivatedRoute) { }


  edit: IEditVehicleData = {
    name: "",
    type: "",
    category: "",
    complaint: "",
    cost: 0,
    username: '',
    date: new Date()
  }
  id: number = 0
  ngOnInit(): void {
    this._vehicleService.getVehicleById(this.activeRoute.snapshot.params['id'])
      .subscribe((res: IVehicle) => {
        // console.log(res)
        this.id = res.id;
        this.edit = res;
        // console.log(this.edit);
        
      })
  }


  editVehicle() {
    // console.log(this.edit)
    this._vehicleService.editVehicle(this.id, this.edit)
      .subscribe(res => {
        this.router.navigate(['vehiclelist'])
      })
  }


}

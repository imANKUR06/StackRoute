import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IVehicle } from 'src/app/models/vehicle/vehicle';
import { IEditVehicleData } from 'src/app/models/vehicle/vehicleData';
import { VehicleService } from 'src/app/services/vehicle/vehicle.service';

@Component({
  selector: 'app-delete-vehicle',
  templateUrl: './delete-vehicle.component.html',
  styleUrls: ['./delete-vehicle.component.css']
})
export class DeleteVehicleComponent implements OnInit {

  constructor(private _vehicleService: VehicleService,
    private router: Router, private activeRoute: ActivatedRoute){}
    
delete: IEditVehicleData = {
  name: "",
  type: "",
  category: "",
  complaint: "",
  cost: 0,
  username: '',
  date: new Date()
  }
id:number=0;
  ngOnInit(): void {
    this._vehicleService.getVehicleById(this.activeRoute.snapshot.params['id'])
      .subscribe((res:any) => {
          // console.log(res)
        this.delete = res;
        this.id = res.id
      }) }

  deleteVehicle(){
        // console.log(this.delete)
        this._vehicleService.deleteVehicle(this.id)
        .subscribe(res => {
          this.router.navigate(['/vehiclelist'])
        })}

}

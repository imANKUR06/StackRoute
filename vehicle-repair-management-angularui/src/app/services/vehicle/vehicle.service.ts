import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IVehicle } from 'src/app/models/vehicle/vehicle';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IEditVehicleData, IVehicleData } from 'src/app/models/vehicle/vehicleData';

@Injectable({providedIn: 'root'})
export class VehicleService {
    constructor(private httpClient: HttpClient) { }

    getVehicles():Observable<IVehicle[]> {
        return this.httpClient.get<IVehicle[]>(environment.baseApiUrl+'api/vehicle');
    }

    addVehicle(vehicle:IVehicleData){
        return this.httpClient.post<any>(environment.baseApiUrl+'api/vehicle/createvehicle',vehicle);
    }

    getVehicleById(id:number){
        return this.httpClient.get<IVehicle>(environment.baseApiUrl+'api/vehicle/'+id)
    }

    editVehicle(id:number, edit: IEditVehicleData){        
        return this.httpClient.put<IEditVehicleData>(environment.baseApiUrl+'api/vehicle/'+id.toString(),edit)
    }

    deleteVehicle(id:number){
        return this.httpClient.delete(environment.baseApiUrl+'api/vehicle/'+id,{responseType:'text'})
    }

    searchByName(name:string):Observable<IVehicle[]>{
        return this.httpClient.get<IVehicle[]>(environment.baseApiUrl+'api/Vehicle/getvehicle/'+name);
    }


}
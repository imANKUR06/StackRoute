import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ILogin, ILoginResponse } from 'src/app/models/authentication/login';
import { IRegister } from 'src/app/models/authentication/register';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';

@Injectable({providedIn: 'root'})
export class AuthenticationService {
    expireTimeString:string =''+localStorage.getItem('expiration');
    
    constructor(private httpClient: HttpClient, private router:Router) { }

    login(login:ILogin){
        return this.httpClient.post<any>(environment.baseApiUrl+'api/authentication/login',login);
    }
    register(registrationData:IRegister){
        return this.httpClient.post<any>(environment.baseApiUrl+'api/authentication/register',registrationData);
    }
    getToken() {
        return localStorage.getItem('token');
    }
    loggedIn(){
        let currentTime= new Date().getTime();
        let expirationTime = new Date(''+localStorage.getItem('expiration')).getTime();
        return  !!(localStorage.getItem('token') && currentTime<expirationTime );
    }
    logout(){
        localStorage.removeItem('token');
        sessionStorage.removeItem('username');
        localStorage.removeItem('expiration');
        this.router.navigate(['/login']);
        
    }
    
}
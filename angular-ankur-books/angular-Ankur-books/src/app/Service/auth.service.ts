import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ILoginResponse } from '../Models/loginResponse';
import { ILogin } from '../Models/login';
import { Router } from '@angular/router';
import { IAddBook } from '../Models/addBook';
import { IRegister } from '../Models/register';
import { environment } from 'src/environments/environment';

@Injectable({providedIn: 'root'})
export class LoginService {
    baseUrl:string = environment.baseUrl+ 'api/authentication/login'
   
    
    
    
    constructor(private httpClient: HttpClient,private router:Router) { }
   
   
    login(loginData: ILogin)
    {
        return this.httpClient.post<ILoginResponse>(this.baseUrl,loginData)
    }
    getToken()
    {
        return localStorage.getItem('token')
    }
    loggedIn()
    {
        return !!localStorage.getItem('token')
    }
    logOut()
    {
        localStorage.removeItem('token')
        this.router.navigate(['/login'])
    }
   


    
}
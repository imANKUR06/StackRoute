import { Injectable } from '@angular/core';
import {  CanActivate, Router } from '@angular/router';
import { LoginService } from '../Service/auth.service';

@Injectable({providedIn: 'root'})
export class AuthGuard implements CanActivate {
    constructor(private authService:LoginService,private router:Router) { }

    canActivate():boolean {
        if(this.authService.loggedIn())
        {
            return true
        }
        else{
            this.router.navigate(['login'])
            return false
        }
    }
}
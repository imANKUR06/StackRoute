import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ILogin } from 'src/app/models/authentication/login';
import { AuthenticationService } from 'src/app/services/authentication/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginDetails:ILogin = {
    username:'',
    password:''
  }
  
  constructor(private authService:AuthenticationService, private router:Router) { }

  ngOnInit(): void {
  }

  login(){
    this.authService.login(this.loginDetails)
    .subscribe(res =>{
      // console.log(res.error);
      switch(res.statusCode)
      {
        case 200:
          sessionStorage.setItem('username', this.loginDetails.username);
          localStorage.setItem('token',res.token);
          localStorage.setItem('expiration',res.expiration.toString());
      // console.log(sessionStorage.getItem('username'));
          location.replace("/");
          this.router.navigate(['/home'])
          break;
        case 403:
          alert(res.message)
          break;
        case 404:
          alert(res.message)
          
      }
      
    })

  }



}

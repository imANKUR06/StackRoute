import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IRegister } from 'src/app/models/authentication/register';
import { AuthenticationService } from 'src/app/services/authentication/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private authService:AuthenticationService, private router:Router) { }
  
  ngOnInit(): void {
  }

  registrationData:IRegister = {
    username:"",
    password:"",
    email:""
  }

  register(){
    // console.log(this.registrationData);
    this.authService.register(this.registrationData)
    .subscribe(res=>{
      if(res.statusCode === 200)
      {
        this.router.navigate(['/login'])
      }else{
        alert(res.message)
      }
      
    })
  }

}


import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ILogin } from 'src/app/Models/login';
import { LoginService } from 'src/app/Service/auth.service';

@Component({
  selector: 'app-authentication',
  templateUrl: './authentication.component.html',
  styleUrls: ['./authentication.component.css']
})
export class AuthenticationComponent implements OnInit {
 
  constructor(private authService:LoginService,private router:Router) { }
  book:ILogin={
    username:'',
    password:''
  }
  ngOnInit(): void {
  } 
  login()
  {
    this.authService.login(this.book)
        .subscribe(arg =>{
          localStorage.setItem('token',arg.token)
          // console.log(this.book)
          this.router.navigate(['/home'])
        });
        
  }

}

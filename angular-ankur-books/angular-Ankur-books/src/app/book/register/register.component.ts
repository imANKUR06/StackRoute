import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IRegister } from 'src/app/Models/register';
import { LoginService } from 'src/app/Service/auth.service';
import { BookService } from '../book.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private registerB:BookService ,private router:Router ) { }

  ngOnInit(): void {
  }
  RegisterBook:IRegister={
    username:'',
    email:'',
    password:''
  }
  register()
  {
    this.registerB.register(this.RegisterBook)
        .subscribe(res=> {
          // console.log(this.RegisterBook)
          this.router.navigate(['login'])
        })
  }

}

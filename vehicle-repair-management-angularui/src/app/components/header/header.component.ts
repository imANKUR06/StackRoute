import { Component, Input, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/services/authentication/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})


export class HeaderComponent implements OnInit{

  

  constructor(private authService:AuthenticationService) { }
  userName:string = '';
  ngOnInit(): void {
    this.userName = ''+sessionStorage.getItem('username');
  }

  // hideNav(){
  //   if(this.authService.loggedIn === true)
  //   this.hide=!this.hide;
  // }

  

  logout(){
    this.authService.logout();
    location.replace("/");
  }
}

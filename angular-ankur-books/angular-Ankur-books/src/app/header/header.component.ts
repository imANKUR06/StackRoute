import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../Service/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private authService:LoginService,private router:Router) { }

  ngOnInit(): void {
  }
  logOut()
  {
    this.authService.logOut();
  }
  display():boolean
  {
    if(this.authService.loggedIn())
    {
      return true
    }
    else{
      
        return false
   }
  }

}

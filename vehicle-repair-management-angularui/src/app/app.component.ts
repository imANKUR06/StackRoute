import { Component } from '@angular/core';
import { AuthenticationService } from './services/authentication/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private auth:AuthenticationService){}
  
  title = 'vehicle-repair-management';

  isNavigation():boolean{
    return this.auth.loggedIn();

  }
}

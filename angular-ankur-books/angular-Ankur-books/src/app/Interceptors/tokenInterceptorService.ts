import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable, Injector } from "@angular/core";
import { Observable } from "rxjs";
import { LoginService } from '../Service/auth.service';


/*

1. Interceptor is used to add additional information on to the incoming request.

2. Here we have used to add the Authorization Bearer token in the request header.

3. All request will pass through this interceptor and it will have its header set with the value passed.

4. Mention this interceptor in the providers array in the app.module.ts

eg:
 providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptorService,
      multi:true
    }
  ]

*/



@Injectable()
export class TokenInterceptorService implements HttpInterceptor{
    
    constructor(private injector:Injector) {     
    }
    
    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        
         // create an instance of AUthenticationService.
        let authService = this.injector.get(LoginService);
        
        let tokenizedRequest = req.clone({
            headers: req.headers.set('Authorization', 'Bearer ' + authService.getToken())
        })
        return next.handle(tokenizedRequest)

    }
}
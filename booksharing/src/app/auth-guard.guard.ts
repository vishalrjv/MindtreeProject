import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthenticationService } from './authentication.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardGuard implements CanActivate {
  constructor(private auth:AuthenticationService,public router:Router){}
  canActivate():boolean{
    if(!this.auth.isAuthenticated()){
      console.log("you are not authorised to view this page");
      return false;
    }
    return true;
  }
   
   
  
  
}

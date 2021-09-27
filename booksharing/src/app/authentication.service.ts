import { Injectable } from '@angular/core';
import {HttpClient,HttpClientModule, HttpHeaders} from '@angular/common/http';

import { Observable,of,throwError,pipe } from 'rxjs';
import {map,filter,catchError,mergeMap} from 'rxjs/operators';
import { User } from './user';


@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  public apiUrl:string="https://localhost:44372/api/users";

  constructor(private http:HttpClient) { }
  ValidateUser(user:User){
    var userData= "EmailId=" +user.EmailId +"&Password=" +user.Password + "&grant_type=Password";
    var reqHeader= new HttpHeaders({'Content-Type':'application/x-www-form-urlencoded','No-Auth':'True'});
    return this.http.post(this.apiUrl+ '/token', userData,{headers:reqHeader}).pipe(map(res=>res),catchError(this.errorHandler));
  }
  errorHandler(error:Response){
    console.log(error);
    return throwError(error);
     }
     public isAuthenticated():boolean{
       return this.getToken !==null;
     }

     storeToken(token:string){
       localStorage.setItem("token",token);
     }
     getToken(){
       return localStorage.getItem("token");
     }
     removeToken(){
       return localStorage.removeItem("token");
     }
}

import { Injectable } from '@angular/core';
import {HttpClient,HttpClientModule} from '@angular/common/http';

import { Observable,of,throwError,pipe } from 'rxjs';
import {map,filter,catchError,mergeMap} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RegserviceService {
  public apiUrl :string="https://localhost:44372/api/users";

  constructor(private http:HttpClient) { }
  RegisterUser(user:any){
    return this.http.post(this.apiUrl,user).pipe(map(res=>res),catchError(this.errorHandler));
  }
  errorHandler(error:Response){
 console.log(error);
 return throwError(error);
  }
}

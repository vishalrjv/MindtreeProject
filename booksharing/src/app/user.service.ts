import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class UserService {
  Url! :string;
  token: string='';
  header: any ;
  constructor(private http:HttpClient) {
    this.Url = 'http://localhost:44372/api/Users/';

    const headerSettings: {[name: string]: string | string[]; } = {};
    this.header = new HttpHeaders(headerSettings);
   }
  // addUser(user: User){
  //   let users=[];
  //   if(localStorage.getItem('Users')){
  //     users=JSON.parse(localStorage.getItem('Users')|| '{}');
  //     users=[user, ...users];
  //   }
  //   else{
  //     users=[user];
  //   }
  //   localStorage.setItem('Users',JSON.stringify(users));
  // }
  // Login(model : any){
  //   // debugger;
  //    var a =this.Url+'Login';
  //  return this.http.post<any>(a,model,{ headers: this.header});
  // }
  // addUser(user:User)
  //  {
  //   const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
  //   return this.http.post<User[]>(this.Url +'Registration', user,httpOptions)
  //  }
 
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import {  UserForLogin, UserForRegister } from './user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl ="https://localhost:44372/api";
  constructor(private http: HttpClient) { }

  authUser(user: UserForLogin) {
      return this.http.post(this.baseUrl + '/account/login', user);
  }

  registerUser(user: UserForRegister) {
      return this.http.post(this.baseUrl + '/account/register', user);
  }
}

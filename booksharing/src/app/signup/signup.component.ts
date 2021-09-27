import { JsonPipe } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../auth.service';

import { RegserviceService } from '../regservice.service';
import { UserForLogin, UserForRegister } from '../user';

import { UserService } from '../user.service';


@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
 signupform!: FormGroup;
 userSubmitted!:boolean;
 user!: UserForRegister;
 
  
  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    this.signupform = new FormGroup({

      FirstName:new FormControl(null, Validators.required),
      Password: new FormControl(null, [Validators.required,Validators.minLength(8)]),
     
      
      EmailId: new FormControl(null),

    });
  }
 
 
  OnSubmit(){
    this.userSubmitted=true;
    if(this.signupform.valid){
    this.authService.registerUser(this.userData()).subscribe(()=>{
      this.onReset()
      alert("registration successful")
    },(error)=>{
      alert("error");
    }
    );}
   
  }
  onReset() {
    this.userSubmitted = false;
    this.signupform.reset();
}
  userData():UserForRegister{
    return this.user={
     FirstName:this.FirstName.value,
      Password:this.Password.value,
      
      EmailId:this.EmailId.value
    }
  }
  get FirstName(){
    return this.signupform.get('FirstName') as FormControl;
  }
 
 get  Password (){
  return this.signupform.get('Password') as FormControl;
 }
 
 get  EmailId (){
  return this.signupform.get('EmailId') as FormControl;
 }
 get f(){
  return this.signupform.controls;
}



  }
 

  
  
 


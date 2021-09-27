import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { AuthService } from '../auth.service';
import { UserForLogin } from '../user';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  userfor!:UserForLogin;
 
  constructor(private authService: AuthService,
    
    private router: Router) { }

  ngOnInit() {
    // document.body.classList.add('bg-img');
    
   }
  onLogin(loginForm:NgForm){

    console.log(loginForm.value);
    // const token = this.authService.authUser(loginForm.value);
    this.authService.authUser(loginForm.value).subscribe(
        (response:any) => {
            console.log(response);
            const user = response;
            if (user) {
                localStorage.setItem('token', user.token);
                localStorage.setItem('emailid', user.EmailId);
                alert('Login Successful');
                this.router.navigate(['/landing']);
            }
        },(error)=>{
          alert(error.error);
          
        }
    );
     
          }
  
            
          
  


 
}

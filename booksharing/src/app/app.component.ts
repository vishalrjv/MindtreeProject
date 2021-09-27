import { Component } from '@angular/core';
import { CartService } from './cart.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public totalItem : number = 0;
  title = 'booksharing';
  loggedinuser!: string;
  constructor(private cartservice:CartService){}
  ngOnInit(): void {
    this.cartservice.getProducts()
    .subscribe(res=>{
      this.totalItem = res.length;
    })
  }
  loggedIn(){
    this.loggedinuser= localStorage.getItem('token')!;
    return this.loggedinuser
  }
  onLogout(){
    localStorage.removeItem('token');
    alert("logout successful")
  }
}

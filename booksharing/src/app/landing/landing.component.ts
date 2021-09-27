import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Book } from '../book';
import { CartService } from '../cart.service';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.css']
})
export class LandingComponent implements OnInit {
Properties:Book[]=[];
  constructor(private http:HttpClient,private cartservice:CartService){ }
// bookList:Array<any>=JSON.parse(localStorage.getItem('Book')!);
url:string="https://localhost:44372/api/bookfinal";
  ngOnInit(): void {
    this.http.get(this.url).subscribe(
      (data)=>{this.Properties= data as Book[];
        this.Properties.forEach((a:Book)=>{
          Object.assign(a,{quantity:1,total:a.price});
      },
      (err: { status: number; })=>{
        if(err.status===404){
          alert('Api not available');
        }
        else if(err.status===500){
          alert('Server Error');
        }
      });
   })
  
  
  }
  addtocart(item: any){
    this.cartservice.addtoCart(item);
  }
  
}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CartService } from '../cart.service';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  public BookList : any ;
  constructor(private cartservice:CartService,private http:HttpClient) { }

  url:string="https://localhost:44372/api/bookfinal";
  ngOnInit(): void {
    this.http.get(this.url).subscribe(
      (data)=>{this.BookList= data;
      this.BookList.foreach((a:any)=>{
        Object.assign(a,{quantity:1,total:a.price});
      })
    
    },
      
      );
   }
   addtocart(item: any){
    this.cartservice.addtoCart(item);
  }

}

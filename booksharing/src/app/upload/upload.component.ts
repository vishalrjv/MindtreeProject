import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Book } from '../book';


@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {
bookform!:FormGroup;
// selectedFile!: File;
// formSubmitted!:boolean;
  constructor(private router:Router,private http:HttpClient) {

   }

  ngOnInit(): void {
    this.bookform=new FormGroup({
      authorName: new FormControl('',Validators.required),
      category:new FormControl('',Validators.required),
      price:new FormControl(0,Validators.required),
      bookName:new FormControl('',Validators.required)
     
    })
  }
  SaveBook(){
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) }; 
    this.http.post<Book>("https://localhost:44372/api/bookfinal",this.bookform.value,httpOptions).subscribe(data=>{
      alert('book saved'); 
      this.router.navigate(['/landing']);

    },error=>{
      alert('not saved');
    })

  }
 
}

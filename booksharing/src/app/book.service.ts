import { Injectable } from '@angular/core';
import { Book } from './book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor() { }
  addBook(book:Book){
    localStorage.setItem('Book',JSON.stringify(book));
  }
}

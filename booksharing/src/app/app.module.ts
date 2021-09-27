import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignupComponent } from './signup/signup.component';
import { LoginComponent } from './login/login.component';
import { Router } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserService } from './user.service';
import { AuthService } from './auth.service';
import { LandingComponent } from './landing/landing.component';
import{BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {BsDropdownModule} from 'ngx-bootstrap/dropdown';
import { UploadComponent } from './upload/upload.component';
import { RegserviceService } from './regservice.service';
import { ViewBookComponent } from './view-book/view-book.component';
import { HomeComponent } from './home/home.component';
import { CartComponent } from './cart/cart.component';
import { BookComponent } from './book/book.component';
import { CartService } from './cart.service';



@NgModule({
  declarations: [
    AppComponent,
    SignupComponent,
    LoginComponent,
    LandingComponent,
    UploadComponent,
    ViewBookComponent,
    HomeComponent,
    CartComponent,
    BookComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    HttpClientModule
  ],
  providers: [UserService,AuthService,RegserviceService,CartService],
  bootstrap: [AppComponent]
})
export class AppModule { }

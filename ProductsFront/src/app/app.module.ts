import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductAllComponent } from './product-all/product-all.component';
import { ProductGetComponent } from './product-get/product-get.component';
import { CartAllComponent } from './cart-all/cart-all.component';
import { ProductsService } from './products.service';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule, MatFormFieldModule, MatInputModule, MatRippleModule, MatTableModule } from '@angular/material';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CartsService } from './carts.service';


const modules = [
  MatButtonModule,
  MatFormFieldModule,
  MatInputModule,
  MatRippleModule
];

@NgModule({
  declarations: [
    AppComponent,
    ProductAllComponent,
    ProductGetComponent,
    CartAllComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule,
    MatTableModule,
    Ng2SearchPipeModule,
    BrowserModule
  ],
  exports:[
    AppRoutingModule,
    RouterModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule,
    MatTableModule,
    Ng2SearchPipeModule
  ],
  providers: [ ProductsService,
  CartsService ],
  bootstrap: [AppComponent]
})
export class AppModule { }

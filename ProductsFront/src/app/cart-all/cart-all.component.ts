import { JsonPipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { CartsService } from '../carts.service';
import Cart from './Cart';
import CartItem from './CartItem';

@Component({
  selector: 'app-cart-all',
  templateUrl: './cart-all.component.html',
  styleUrls: ['./cart-all.component.css']
})
export class CartAllComponent implements OnInit {
  // cart: Cart = new Cart();

  cart: Cart = {
    SessionId : "",
    Id : "",
    ShoppingCartStatus : "",
    cartItems : []
  };


  constructor(private cs: CartsService) { }

  ngOnInit() {
   this.cs.getCart().subscribe(res => this.cart = res);
   
  }
}

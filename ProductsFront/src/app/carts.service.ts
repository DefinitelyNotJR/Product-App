import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Cart from './cart-all/Cart';
import CartItem from './cart-all/CartItem';
import Product from './product-all/Product';

@Injectable({
  providedIn: 'root'
})
export class CartsService {

  uri = 'https://localhost:5001/ShoppingCart';

  constructor(private http: HttpClient) { }

  getCart(): Observable<Cart> {
    return this.http.get<Cart>(this.uri, { withCredentials: true });
  }
}


import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Product from './product-all/Product';

@Injectable({
  providedIn: 'root'
})


export class ProductsService {


  uri = 'https://localhost:5001/Product';

  constructor(private http: HttpClient) { }

  getAllProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.uri);
  }

  getProduct(id) {
    return this
            .http
            .get(`${this.uri}/${id}`);
    }

}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import Product from '../product-all/Product';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { ProductsService } from '../products.service';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-product-get',
  templateUrl: './product-get.component.html',
  styleUrls: ['./product-get.component.css']
})
export class ProductGetComponent implements OnInit {

  angForm: FormGroup;
  product: any = {};

  constructor(private route: ActivatedRoute, private router: Router, private ps: ProductsService) {
  }

  

  ngOnInit() {
    this.product = this.route.paramMap.pipe(
      switchMap((params: ParamMap) => 
      this.ps.getProduct(params.get('id')))
    );


  }

}

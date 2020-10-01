import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
import Product from '../product-all/Product';
import { ProductsService } from '../products.service';


@Component({
  selector: 'app-product-all',
  templateUrl: './product-all.component.html',
  styleUrls: ['./product-all.component.css']
})
export class ProductAllComponent implements OnInit {

  listData: MatTableDataSource<any>;
  products: Product[] = [];
  columndefs: any[] = ['name'];



  constructor(private ps: ProductsService) { }

  ngOnInit() {
    this.ps.getAllProducts().subscribe(res => this.products = res);

  }

  applyFilter(filterValue: string){
    this.listData.filter = filterValue.trim().toLocaleLowerCase();
  }
}

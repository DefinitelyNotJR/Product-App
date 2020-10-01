import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CartAllComponent } from './cart-all/cart-all.component';
import { ProductAllComponent } from './product-all/product-all.component';
import { ProductGetComponent } from './product-get/product-get.component';


const routes: Routes = [
  {
    path: 'products',
    component: ProductAllComponent
  },
  {
    path: 'product/:id',
    component: ProductGetComponent
  },
  {
    path: 'cart',
    component: CartAllComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

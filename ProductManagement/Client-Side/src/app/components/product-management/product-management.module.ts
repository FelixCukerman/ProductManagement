  
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductManagementComponent } from '../product-management/product-management.component';
import { Routes, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import {NgxPaginationModule} from 'ngx-pagination';

const routes: Routes =
  [
    {
      path: 'productmanagement',
      component: ProductManagementComponent
    }
  ];

@NgModule({
  declarations: [
    ProductManagementComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    FormsModule,
    NgxPaginationModule
  ]
})
export class ProductManagementModule { }
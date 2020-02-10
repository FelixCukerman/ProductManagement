import { Component, OnInit } from '@angular/core';
import { ProductManagementService } from 'src/app/services/product-management.service';
import { RequestGetProductsViewModel } from 'src/app/viewModels/product-management-viewModels/product-management-viewModels/request/request-get-products-ViewModel';
import { ResponseGetProductsViewModel, ResponseGetProductsViewModelItem } from 'src/app/viewModels/product-management-viewModels/product-management-viewModels/response/response-get-products-viewModel';
import { RequestCreateProductViewModel } from 'src/app/viewModels/product-management-viewModels/product-management-viewModels/request/request-create-product-viewModel';
import { ResponseGetCategoriesViewModel } from 'src/app/viewModels/product-management-viewModels/product-management-viewModels/response/response-get-categories-viewModel';

import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-product-management',
  templateUrl: './product-management.component.html',
  styleUrls: ['./product-management.component.css']
})
export class ProductManagementComponent implements OnInit {
  closeResult: string;
  
  public requestGetProducts: RequestGetProductsViewModel;
  public products: ResponseGetProductsViewModel;
  public requestCreateProduct: RequestCreateProductViewModel;
  public categories: ResponseGetCategoriesViewModel;
  public currentPage: number = 1;

  constructor(private _service: ProductManagementService, private modalService: NgbModal) { }

  ngOnInit(): void {
    this.initializeData();
    this.getCategories();
    this.getProducts();
  }

  private getProducts() {
    debugger;
    this._service.getProducts(this.requestGetProducts).subscribe((data: ResponseGetProductsViewModel) => 
    { 
      this.products = data;
    });
  }

  public createProduct() {
    this._service.createProduct(this.requestCreateProduct).subscribe((data: ResponseGetProductsViewModelItem) => {
      this.products.data.push(data);
    });
  }

  public setSelectedCategory(value: any) {
    this.requestCreateProduct.categoryId = value;
  }

  public getCategories() {
    this._service.getCategories().subscribe((data: ResponseGetCategoriesViewModel) => {
      this.categories = data;
    });
  }

  public open(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
    }, (reason) => {
    });
  }

  public pageChanged($event): void {
    this.requestGetProducts.index = ($event - 1) * 10;
    this.getProducts();
  }

  private initializeData() {
    this.products = new ResponseGetProductsViewModel([], 0);
    this.requestGetProducts = new RequestGetProductsViewModel(0, 10);
    this.categories = new ResponseGetCategoriesViewModel([]);
    this.requestCreateProduct = new RequestCreateProductViewModel('', 0);
  }
}
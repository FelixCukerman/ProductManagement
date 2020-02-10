import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { RequestGetProductsViewModel } from '../viewModels/product-management-viewModels/product-management-viewModels/request/request-get-products-ViewModel';
import { RequestCreateProductViewModel } from '../viewModels/product-management-viewModels/product-management-viewModels/request/request-create-product-viewModel';

@Injectable({
  providedIn: 'root'
})
export class ProductManagementService
{
  private _url = environment.productManagementUrl;

  constructor(private _http: HttpClient) { }

  public getProducts(request: RequestGetProductsViewModel): Observable<Object>
  {
    let result: Observable<Object> = this._http.post(`${this._url}/list`, request);

    return result;
  }

  public createProduct(request: RequestCreateProductViewModel): Observable<Object>
  {
    let result: Observable<Object> = this._http.post(`${this._url}/create`, request);

    return result;
  }

  public getCategories() {
    let result: Observable<Object> = this._http.get(`${this._url}/categories`);

    return result;
  }
}
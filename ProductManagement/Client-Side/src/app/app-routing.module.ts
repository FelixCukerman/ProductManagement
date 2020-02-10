import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [    
{
  path: '',
  pathMatch: 'full',
  redirectTo: 'productmanagement'
},
{
  path: '',
  loadChildren: () => import('./components/product-management/product-management.module').then(m => m.ProductManagementModule)
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

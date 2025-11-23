import { Routes } from '@angular/router';
import { HomePage } from './home-page/home-page';
import { ShoppingCartPage } from './shopping-cart-page/shopping-cart-page';
import {ProdactsListPage } from './prodact-list-page/prodact-list-page';

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    {path:'home', component: HomePage},
    {path:'prodacts', component: ProdactsListPage},
    {path:'shopping', component: ShoppingCartPage}
];
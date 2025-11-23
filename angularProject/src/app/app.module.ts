//מאפשר לאנגולר לבצע קריא HTTP לWEBAPI
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { HomePage } from './home-page/home-page';
import { ProdactsListPage } from './prodact-list-page/prodact-list-page';
import { ShoppingCartPage } from './shopping-cart-page/shopping-cart-page';
import { CustomersService } from './services/customers';
//מערך של קומפוננטות:
declarations: [
 HomePage,
 ProdactsListPage,
 ShoppingCartPage
]
imports: [
  BrowserModule,
  HttpClientModule,
  CustomersService
]
//איזה קומפוננטה עולה ראשונה
bootstrap: [HomePage]
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieDescriptionComponent } from './movie-description/movie-description.component';
import { MoviesComponent } from './movies/movies.component';
import { ShoppingcartComponent } from './shoppingcart/shoppingcart.component';
import { MyOrderHistoryComponent } from './my-order-history/my-order-history.component';
import { LoginScreenComponent } from './login-screen/login-screen.component';
import { MoviedateComponent } from './moviedate/moviedate.component';
import { ShowtimeComponent } from './showtime/showtime.component';
import { CustomerComponent } from './customer/customer.component';


const routes: Routes = [
  { path: '', redirectTo: '/movies', pathMatch: 'full' },
  { path: 'movies', component: MoviesComponent, pathMatch: 'full' },
  { path: 'movie/:id', component: MovieDescriptionComponent },
  { path: 'moviedate/:id', component: MoviedateComponent},
  { path: 'login', component: LoginScreenComponent},
  { path: 'shoppingcart', component: ShoppingcartComponent },
  { path: 'my-order-history', component: MyOrderHistoryComponent },
  { path: 'showtime/:id', component: ShowtimeComponent},
  { path: 'customers', component: CustomerComponent},
  { path: 'PhoenixTheatre/filmShowings', component: MoviesComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

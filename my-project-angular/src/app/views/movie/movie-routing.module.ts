import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { List_movieComponent } from './list_movie.component';
import {FormsMovieComponent} from "./form_movie.component";

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Movie'
    },
    children: [
      {
        path: '',
        redirectTo: 'list_movie'
      },
      {
        path: 'list_movie',
        component: List_movieComponent,
        data: {
          title: 'Catalogo'
        }
      },
      {
        path: 'movie/:id',
        component: FormsMovieComponent,

      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MovieRoutingModule {}

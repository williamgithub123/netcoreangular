// Angular
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { List_movieComponent } from './list_movie.component';

// Theme Routing
import { MovieRoutingModule } from './movie-routing.module';
import {Ng2SmartTableModule} from "ng2-smart-table";
import {FormsMovieComponent} from "./form_movie.component";
import {FormsModule} from "@angular/forms";

@NgModule({
  imports: [
    CommonModule,
    MovieRoutingModule,
    Ng2SmartTableModule,
    FormsModule
  ],
  declarations: [
    List_movieComponent,
    FormsMovieComponent
  ]
})
export class MovieModule { }

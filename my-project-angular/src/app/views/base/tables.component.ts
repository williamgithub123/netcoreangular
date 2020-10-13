import { Component } from '@angular/core';
import {MovieService} from "../../services/movie.service";
import {movieModel} from "../../model/movie.model";

@Component({
  templateUrl: 'tables.component.html'
})
export class TablesComponent {

  listRoles: movieModel[] = [];

  constructor(private movieService: MovieService
  ) { }

  ngOnInit() {
    //this.GetRoles();
  }

  //-------------------------------------------------------------------------------------------------

  // GetRoles() {
  //
  //   this.movieService.GetRoles().subscribe((res: movieModel[]) => {
  //
  //       this.listRoles = res;
  //
  //     },
  //     (error) => {
  //
  //
  //     });
  // }

}

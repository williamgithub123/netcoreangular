import { Component, Inject, OnInit } from '@angular/core';
import { DOCUMENT } from '@angular/common';
import {movieModel} from "../../model/movie.model";
import {MovieService} from "../../services/movie.service";
import {responseModel} from "../../model/response.model";
import {Router} from "@angular/router";

@Component({
  templateUrl: 'list_movie.component.html'
})
export class List_movieComponent implements OnInit {
  constructor(@Inject(DOCUMENT) private _document: any,
              private movieService: MovieService,
              private router: Router)
  {}

  movie: movieModel = {id: 0, director:'', productor: '', year:null, successfull: false};
  showfilter:boolean = false;

  settings = {
    columns:{
      director:{
        title: 'Tílulo'
      },
      productor:{
        title:'Director'
      },
      year:{
        title: 'Año'
      },
    },
    delete:{
      confirmDelete: true,
    },
    add:{

    },
    edit:{

    },
    mode: 'external'

  }

  data: movieModel[] = [];

  ngOnInit(): void {
    this.GetPeliculas();
  }

  //------------------------------------------------------------------------

  GetPeliculas() {

    this.movieService.GetMovies().subscribe((res: responseModel) => {

        if(res.result != undefined){
          this.data = res.result.items;
        }
      },
      (error) => {

      });
  }

  //------------------------------------------------------------------------

  onDeleteConfirm(event){

    let movieId = event.data.id;

    this.movieService.deleteMovie(movieId).subscribe((res: responseModel) => {

        this.GetPeliculas();

      },
      (error) => {
        let result = error;
      });
  }

  //----------------------------------------------------------------------------------

  onCreateConfirm(event){

    this.router.navigate(['/movie/movie/0']);

  }

  //----------------------------------------------------------------------------------

  onSaveConfirm(event){

    let movieId = event.data.id;

    this.router.navigate(['/movie/movie/'+ movieId.toString()]);

  }

  //----------------------------------------------------------------------------------

  Filtrar(){
    this.showfilter = false;

    if(this.movie.director != ''){
       this.data = this.data.filter(value => value.director == this.movie.director);
    }
    if(this.movie.productor != ''){
      this.data = this.data.filter(value => value.productor == this.movie.productor);
    }
    if(this.movie.year != null){
      this.data = this.data.filter(value => value.year == this.movie.year);
    }
  }

  //----------------------------------------------------------------------------------

  ShowFilter(){

    this.movie.director = '';
    this.movie.productor = '';
    this.movie.year = null;

    if(this.showfilter){
      this.showfilter = false;
    }
    else {
      this.showfilter = true;
    }

  }

}

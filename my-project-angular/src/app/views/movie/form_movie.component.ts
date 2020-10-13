import { Component } from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";
import {movieModel} from "../../model/movie.model";
import {responseModel} from "../../model/response.model";
import {MovieService} from "../../services/movie.service";
import {response_objModel} from "../../model/response_obj.model";

@Component({
  templateUrl: 'form_movie.component.html'
})
export class FormsMovieComponent {

  id:string;
  namebutton:string;
  movie: movieModel = {id: 0, director:'', productor: '', year:null, successfull: false};

  constructor(private activatedRoute: ActivatedRoute,
              private movieService: MovieService,
              private router: Router)
  { }

  //--------------------------------------------------------------------------------------------

  ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.paramMap.get('id');

    if(this.id != '0'){
      this.namebutton = 'Actualizar';
      this.GetPelicula();
    }
    else{
      this.namebutton = 'Insertar';
    }
  }

  //------------------------------------------------------------------------

  GetPelicula() {

    this.movieService.GetMovie(this.id).subscribe((res: response_objModel) => {

        if(res.success){
          this.movie = res.result;
        }
      },
      (error) => {
          let result = error;
      });
  }

  //--------------------------------------------------------------------------------------------

  submit(){

    if(this.id != '0'){
      this.onUpdate();
    }
    else{
      this.onInsert();
    }

  }

  //----------------------------------------------------------------------------------

  onUpdate(){

    this.movieService.saveMovie(this.movie).subscribe((res: movieModel) => {
        this.router.navigate(['/movie/list_movie']);
      },
      (error) => {
        let result = error;
      });

  }

  //----------------------------------------------------------------------------------

  onInsert(){

    this.movieService.createMovie(this.movie).subscribe((res: movieModel) => {
        this.router.navigate(['/movie/list_movie']);
      },
      (error) => {
        let result = error;
      });

  }



}

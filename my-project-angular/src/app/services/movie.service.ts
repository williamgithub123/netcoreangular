import {Injectable} from '@angular/core';
import {
    HttpClient,
    HttpHeaders,
    HttpErrorResponse,
    HttpRequest,
    HttpEvent,
    HttpEventType,
    HttpParams
} from '@angular/common/http';
import {tap} from "rxjs/operators";
import {Observable} from "rxjs";
import {error} from "@angular/compiler/src/util";
import {movieModel} from "../model/movie.model";
import {responseModel} from "../model/response.model";
import {response_objModel} from "../model/response_obj.model";


@Injectable({
    providedIn: 'root'
})
export class MovieService {

    SERVER_ADDRESS: string = 'http://localhost:21021/api/services/app';

    constructor(private  httpClient: HttpClient)
    {}

  //POST----------------------------------------------------------------------------------------------------------------------

  createMovie(movie: movieModel): Observable<movieModel> {

    return this.httpClient
      .post<movieModel>(`${this.SERVER_ADDRESS}/Pelicula/Create`, movie)
      .pipe(
        tap(async (res: movieModel) => {

          let result = res;

        }, e => {
          let result = e;
        })
      );
  }

  //POST----------------------------------------------------------------------------------------------------------------------

  saveMovie(movie: movieModel): Observable<movieModel> {

    return this.httpClient
      .put<movieModel>(`${this.SERVER_ADDRESS}/Pelicula/Update`, movie)
      .pipe(
        tap(async (res: movieModel) => {

          let result = res;

        }, e => {
          let result = e;
        })
      );
  }

  //POST----------------------------------------------------------------------------------------------------------------------

  deleteMovie(movieId: number): Observable<responseModel> {

    return this.httpClient
      .delete<responseModel>(`${this.SERVER_ADDRESS}/Pelicula/Delete?Id=`+movieId.toString(), {})
      .pipe(
        tap(async (res: responseModel) => {

          let result = res;

        }, e => {

        })
      );
  }

  //---------------------------------------------------------------------------------------------------------------------------

  GetMovies(): Observable<responseModel> {

    return this.httpClient
      .get<responseModel>(`${this.SERVER_ADDRESS}/Pelicula/GetAll`, {})
      .pipe(
        tap(async (res: responseModel) => {
          let result = res;
        },e => {
          let result = e;
        })
      );
  }

  //---------------------------------------------------------------------------------------------------------------------------

  GetMovie(movieId: string): Observable<response_objModel> {

    return this.httpClient
      .get<response_objModel>(`${this.SERVER_ADDRESS}/Pelicula/Get?Id=`+movieId, {})
      .pipe(
        tap(async (res: response_objModel) => {
          let result = res;
        },e => {
          let result = e;
        })
      );
  }



}

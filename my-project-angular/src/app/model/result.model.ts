import {movieModel} from "./movie.model";

export interface resultModel {

  totalCount: number,
  items: movieModel[],

}

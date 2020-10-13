import {resultModel} from "./result.model";
import {movieModel} from "./movie.model";

export interface response_objModel {
  result: movieModel,
  targetUrl: string,
  success: boolean,
  error: string,
  unAuthorizedRequest: boolean,
  __abp: boolean
}

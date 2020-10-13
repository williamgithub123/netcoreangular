import {resultModel} from "./result.model";
import {movieModel} from "./movie.model";

export interface responseModel {
  result: resultModel,
  targetUrl: string,
  success: boolean,
  error: string,
  unAuthorizedRequest: boolean,
  __abp: boolean
}

import { Entity } from "./entity";

export class BaseRequestModel extends Entity {
    orderBy:string
    isAscending:boolean 
    page:number
    perPageCount:number
    totalPage:number
    totalCount:number
    code:string
    name:string
    marketPlanName:string
   
}
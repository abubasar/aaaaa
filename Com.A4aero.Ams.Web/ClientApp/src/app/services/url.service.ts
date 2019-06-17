import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlService {
  baseUrl:string='http://localhost:8670/api/'
  businessEntity:string
  markupPlan:string
    constructor() { 
      this.businessEntity=this.baseUrl+'business-entity'
      this.markupPlan=this.baseUrl+'markup-plan'

    }
}

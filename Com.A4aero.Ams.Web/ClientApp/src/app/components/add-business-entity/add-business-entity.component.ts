import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../base/base.component';
import { Entity } from 'src/app/entities/entity';
import { BusinessEntityService } from 'src/app/services/business-entity.service';

@Component({
  selector: 'app-add-business-entity',
  templateUrl: './add-business-entity.component.html',
  styleUrls: ['./add-business-entity.component.css']
})
export class AddBusinessEntityComponent extends BaseComponent<any> implements OnInit {
  reset() {
   this.model=new Entity();
  }

  constructor(public service:BusinessEntityService) {
    super(service)
   }

  ngOnInit() {
  }

}

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddBusinessEntityComponent } from './add-business-entity.component';

describe('AddBusinessEntityComponent', () => {
  let component: AddBusinessEntityComponent;
  let fixture: ComponentFixture<AddBusinessEntityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddBusinessEntityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddBusinessEntityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

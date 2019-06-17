import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddMarkupPlanComponent } from './add-markup-plan.component';

describe('AddMarkupPlanComponent', () => {
  let component: AddMarkupPlanComponent;
  let fixture: ComponentFixture<AddMarkupPlanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddMarkupPlanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddMarkupPlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

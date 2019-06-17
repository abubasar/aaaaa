import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditMarkupPlanComponent } from './edit-markup-plan.component';

describe('EditMarkupPlanComponent', () => {
  let component: EditMarkupPlanComponent;
  let fixture: ComponentFixture<EditMarkupPlanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditMarkupPlanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditMarkupPlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

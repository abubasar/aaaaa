import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListMarkupPlanComponent } from './list-markup-plan.component';

describe('ListMarkupPlanComponent', () => {
  let component: ListMarkupPlanComponent;
  let fixture: ComponentFixture<ListMarkupPlanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListMarkupPlanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListMarkupPlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

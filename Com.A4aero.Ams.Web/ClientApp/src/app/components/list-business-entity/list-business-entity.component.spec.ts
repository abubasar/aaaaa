import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListBusinessEntityComponent } from './list-business-entity.component';

describe('ListBusinessEntityComponent', () => {
  let component: ListBusinessEntityComponent;
  let fixture: ComponentFixture<ListBusinessEntityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListBusinessEntityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListBusinessEntityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InterestGroupUpsertComponent } from './interest-group-upsert.component';

describe('InterestGroupUpsertComponent', () => {
  let component: InterestGroupUpsertComponent;
  let fixture: ComponentFixture<InterestGroupUpsertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InterestGroupUpsertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InterestGroupUpsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

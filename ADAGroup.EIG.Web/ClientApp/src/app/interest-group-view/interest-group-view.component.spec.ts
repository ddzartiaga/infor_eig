import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InterestGroupViewComponent } from './interest-group-view.component';

describe('InterestGroupViewComponent', () => {
  let component: InterestGroupViewComponent;
  let fixture: ComponentFixture<InterestGroupViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InterestGroupViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InterestGroupViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

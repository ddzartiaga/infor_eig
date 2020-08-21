import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupFAQsComponent } from './group-faqs.component';

describe('GroupFAQsComponent', () => {
  let component: GroupFAQsComponent;
  let fixture: ComponentFixture<GroupFAQsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupFAQsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupFAQsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

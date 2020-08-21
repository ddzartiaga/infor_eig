import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupFAQFormComponent } from './group-faqform.component';

describe('GroupFAQFormComponent', () => {
  let component: GroupFAQFormComponent;
  let fixture: ComponentFixture<GroupFAQFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupFAQFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupFAQFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

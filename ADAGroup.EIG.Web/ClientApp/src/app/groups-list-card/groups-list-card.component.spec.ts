import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupsListCardComponent } from './groups-list-card.component';

describe('GroupsListCardComponent', () => {
  let component: GroupsListCardComponent;
  let fixture: ComponentFixture<GroupsListCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupsListCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupsListCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

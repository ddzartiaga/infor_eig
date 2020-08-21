import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupInfoUpsertComponent } from './group-info-upsert.component';

describe('GroupInfoUpsertComponent', () => {
  let component: GroupInfoUpsertComponent;
  let fixture: ComponentFixture<GroupInfoUpsertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupInfoUpsertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupInfoUpsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

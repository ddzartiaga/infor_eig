import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminGroupMgmtComponent } from './admin-group-mgmt.component';

describe('AdminGroupMgmtComponent', () => {
  let component: AdminGroupMgmtComponent;
  let fixture: ComponentFixture<AdminGroupMgmtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminGroupMgmtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminGroupMgmtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

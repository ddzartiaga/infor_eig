import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminEventMgmtComponent } from './admin-event-mgmt.component';

describe('AdminEventMgmtComponent', () => {
  let component: AdminEventMgmtComponent;
  let fixture: ComponentFixture<AdminEventMgmtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminEventMgmtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminEventMgmtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

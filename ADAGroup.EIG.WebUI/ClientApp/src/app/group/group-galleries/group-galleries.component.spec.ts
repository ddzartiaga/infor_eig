import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupGalleriesComponent } from './group-galleries.component';

describe('GroupGalleriesComponent', () => {
  let component: GroupGalleriesComponent;
  let fixture: ComponentFixture<GroupGalleriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupGalleriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupGalleriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

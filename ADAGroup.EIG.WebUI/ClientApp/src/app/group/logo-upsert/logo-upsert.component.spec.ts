import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LogoUpsertComponent } from './logo-upsert.component';

describe('LogoUpsertComponent', () => {
  let component: LogoUpsertComponent;
  let fixture: ComponentFixture<LogoUpsertComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LogoUpsertComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LogoUpsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { EIGService } from './eig.service';

describe('EIGService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EIGService = TestBed.get(EIGService);
    expect(service).toBeTruthy();
  });
});

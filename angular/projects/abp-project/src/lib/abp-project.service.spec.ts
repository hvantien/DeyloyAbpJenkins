import { TestBed } from '@angular/core/testing';

import { AbpProjectService } from './abp-project.service';

describe('AbpProjectService', () => {
  let service: AbpProjectService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AbpProjectService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AbpProjectComponent } from './abp-project.component';

describe('AbpProjectComponent', () => {
  let component: AbpProjectComponent;
  let fixture: ComponentFixture<AbpProjectComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AbpProjectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AbpProjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoviedateComponent } from './moviedate.component';

describe('MoviedateComponent', () => {
  let component: MoviedateComponent;
  let fixture: ComponentFixture<MoviedateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MoviedateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MoviedateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TreaaComponent } from './treaa.component';

describe('TreaaComponent', () => {
  let component: TreaaComponent;
  let fixture: ComponentFixture<TreaaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TreaaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TreaaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

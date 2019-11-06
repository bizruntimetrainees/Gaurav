import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormsExmapleComponent } from './forms-exmaple.component';

describe('FormsExmapleComponent', () => {
  let component: FormsExmapleComponent;
  let fixture: ComponentFixture<FormsExmapleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormsExmapleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormsExmapleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

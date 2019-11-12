import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShortheaderComponent } from './shortheader.component';

describe('ShortheaderComponent', () => {
  let component: ShortheaderComponent;
  let fixture: ComponentFixture<ShortheaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShortheaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShortheaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

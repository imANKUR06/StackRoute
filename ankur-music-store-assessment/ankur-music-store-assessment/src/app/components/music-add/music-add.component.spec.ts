import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MusicAddComponent } from './music-add.component';

describe('MusicAddComponent', () => {
  let component: MusicAddComponent;
  let fixture: ComponentFixture<MusicAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MusicAddComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MusicAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

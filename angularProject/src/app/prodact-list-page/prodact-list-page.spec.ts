import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdactListPage } from './prodact-list-page';

describe('ProdactListPage', () => {
  let component: ProdactListPage;
  let fixture: ComponentFixture<ProdactListPage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProdactListPage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProdactListPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

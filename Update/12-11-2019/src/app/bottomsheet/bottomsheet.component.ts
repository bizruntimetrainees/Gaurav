import { Component, OnInit } from '@angular/core';
import {MatBottomSheet, MatBottomSheetRef} from '@angular/material/bottom-sheet';

@Component({
  selector: 'app-bottomsheet',
  templateUrl: './bottomsheet.component.html',
  styleUrls: ['./bottomsheet.component.css']
})
export class BottomsheetComponent  {

  constructor(private _bottomSheet: MatBottomSheet) {}

  openBottomSheet(): void {
    this._bottomSheet.open(BottomSheetBottom);
  }

}

@Component({
  selector: 'bottom-sheet-bottom',
  templateUrl: 'bottom-sheet-bottom.html',
})
export class BottomSheetBottom {
  constructor(private _bottomSheetRef: MatBottomSheetRef<BottomSheetBottom>) {}

  openLink(event: MouseEvent): void {
    this._bottomSheetRef.dismiss();
    event.preventDefault();
  }
}
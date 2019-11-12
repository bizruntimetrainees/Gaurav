import { Component, OnInit, Inject } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

export interface DialogData
{
  fruit : string;
  name : string;
}

@Component({
  selector: 'app-dialog-example',
  templateUrl: './dialog-example.component.html',
  styleUrls: ['./dialog-example.component.css']
})
export class DialogExampleComponent  {

  fruit : string;
  name : string;

  constructor(public dialog : MatDialog) { }

  openDialog() : void
  {
    const dialogRef  = this.dialog.open(DialogExampleDialog,
      {
        width : '250px',
        data: {name: this.name, fruit: this.fruit}
      });
  }
}

@Component({
  selector: 'dialog-example-dialog',
  templateUrl: 'dialog-example-dialog.html',
})
export class DialogExampleDialog {

  constructor(
    public dialogRef: MatDialogRef<DialogExampleDialog>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) {}

  onNoClick(): void {
    this.dialogRef.close();
  }

}

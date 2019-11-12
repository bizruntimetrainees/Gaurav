import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatRadioModule} from '@angular/material/radio';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatCardModule} from '@angular/material/card';
import {MatDatepickerModule} from '@angular/material/datepicker';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CheckboxComponent } from './checkbox/checkbox.component';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import { MatNativeDateModule,MatRippleModule } from '@angular/material/core';
import { StudentFormComponent } from './student-form/student-form.component';
import {MatSelectModule} from '@angular/material/select';
import { FormFieldComponent } from './form-field/form-field.component';
import {MatIconModule} from '@angular/material/icon';
import { NavigationComponent } from './navigation/navigation.component';
import {MatMenuModule} from '@angular/material/menu';
import { SidenavComponent } from './sidenav/sidenav.component';
import {MatButtonModule} from '@angular/material/button';
import {MatSidenavModule} from '@angular/material/sidenav';
import { StepperComponent } from './stepper/stepper.component';
import {MatStepperModule} from '@angular/material/stepper';
import {MatGridListModule} from '@angular/material/grid-list';
import { TabsComponent } from './tabs/tabs.component';
import {MatTabsModule} from '@angular/material/tabs';
import {MatTreeModule} from '@angular/material/tree';
import { TreaaComponent } from './tree/treaa.component';
import { ButtonsComponent } from './buttons/buttons.component';
import {MatChipsModule} from '@angular/material/chips';
import {MatBadgeModule} from '@angular/material/badge';
import {MatBottomSheetModule} from '@angular/material/bottom-sheet';
import {MatDialogModule} from '@angular/material/dialog';
import { BadgesComponent } from './badges/badges.component';
import { DialogExampleComponent, DialogExampleDialog } from './dialog-example/dialog-example.component';
import { SnackbarComponent } from './snackbar/snackbar.component';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import {MatTooltipModule} from '@angular/material/tooltip';
import { TooltipComponent } from './tooltip/tooltip.component';
import { BottomsheetComponent, BottomSheetBottom } from './bottomsheet/bottomsheet.component';
import { ShortheaderComponent } from './shortheader/shortheader.component';
import {MatSortModule} from '@angular/material/sort';
import {MatTableModule} from '@angular/material/table';
import {MatListModule} from '@angular/material/list';
import {MatPaginatorModule} from '@angular/material/paginator';




@NgModule({
  declarations: [
    AppComponent,
    CheckboxComponent,
    DatePickerComponent,
    StudentFormComponent,
    FormFieldComponent,
    NavigationComponent,
    SidenavComponent,
    StepperComponent,
    TabsComponent,
    TreaaComponent,
    ButtonsComponent,
    BadgesComponent,
    DialogExampleComponent,
    DialogExampleDialog,
    SnackbarComponent,
    TooltipComponent,
    BottomsheetComponent,
    ShortheaderComponent,
    BottomSheetBottom,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatCheckboxModule,
    MatRadioModule,
    FormsModule,
    MatCardModule,
    MatDatepickerModule,
    MatInputModule,
    MatFormFieldModule,
    MatNativeDateModule,
    ReactiveFormsModule,
    MatRippleModule,
    MatSelectModule,
    MatIconModule,
    MatMenuModule,
    MatButtonModule,
    MatSidenavModule,
    MatStepperModule,
    MatGridListModule,
    MatTabsModule,
    MatTreeModule,
    MatChipsModule,
    MatBottomSheetModule,
    MatDialogModule,
    MatBadgeModule,
    MatSnackBarModule,
    MatTooltipModule,
    MatSortModule,
    MatTableModule,
    MatListModule,
    MatPaginatorModule
    
    
  ],
  exports :[],
  entryComponents: [
    DialogExampleDialog,
    BottomSheetBottom
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

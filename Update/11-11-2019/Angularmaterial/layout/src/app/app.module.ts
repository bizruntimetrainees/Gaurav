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

import {MatBottomSheetModule} from '@angular/material/bottom-sheet';

import { BadgesComponent } from './badges/badges.component';



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
    BadgesComponent
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
    MatBottomSheetModule
    
    
  ],
  exports :[],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

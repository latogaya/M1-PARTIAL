import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { PctableComponent } from './pctable/pctable.component';
import { ShowPartsComponent } from './pctable/show-parts/show-parts.component';
import { AddEditPartsComponent } from './pctable/add-edit-parts/add-edit-parts.component';


@NgModule({
  declarations: [
    AppComponent,
    PctableComponent,
    ShowPartsComponent,
    AddEditPartsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {
   MatButtonModule,
   MatCheckboxModule, 
   MatToolbarModule,
   MatIconModule,
   MatMenuModule,
   MatCardModule
  } from '@angular/material'

import { AppComponent } from './app.component';
import { MembersComponent } from './members/members.component';
import { ListMembersComponent } from './members/list-members/list-members.component';
import { MenuComponent } from './menu/menu.component';

@NgModule({
  declarations: [
    AppComponent,
    MembersComponent,
    ListMembersComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,

    MatButtonModule,
    MatCheckboxModule,
    MatToolbarModule,
    MatIconModule,
    MatMenuModule,
    MatCardModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
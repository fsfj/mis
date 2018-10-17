import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'

import { AppComponent } from './app.component';
import { MembersComponent } from './members/members.component';
import { ListMembersComponent } from './members/list-members/list-members.component';

@NgModule({
  declarations: [
    AppComponent,
    MembersComponent,
    ListMembersComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

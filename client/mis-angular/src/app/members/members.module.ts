import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListMembersComponent } from './list-members/list-members.component';
import { MembersComponent } from './members.component';
import { UpdateMemberComponent } from './update-member/update-member.component';
import { CreateMemberComponent } from './create-member/create-member.component';

import { HttpClientModule } from '@angular/common/http';

import {MatButtonModule, MatCheckboxModule} from '@angular/material';
import { MembersService } from './members.service';

@NgModule({
  imports: [
    CommonModule,
    MatButtonModule,
    MatCheckboxModule,
    HttpClientModule
  ],
  declarations: [
    ListMembersComponent,
    MembersComponent,
    UpdateMemberComponent,
    CreateMemberComponent
  ],
  exports: [
    MembersComponent
  ],
  providers: [
    MembersService
  ]
})
export class MembersModule { }

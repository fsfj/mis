import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router'
import { MembersComponent } from '../components/members/members.component';
import { HomeComponent } from '../components/home/home.component';

const routes: Routes = [
  { path: 'members', component: MembersComponent },
  { path: '', component: HomeComponent}
]
@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }

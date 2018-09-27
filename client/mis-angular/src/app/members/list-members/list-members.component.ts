import { Component, OnInit } from '@angular/core';
import { MembersService } from '../members.service';
import { Member } from '../model/member.model';

@Component({
  selector: 'app-list-members',
  templateUrl: './list-members.component.html',
  styleUrls: ['./list-members.component.css']
})
export class ListMembersComponent implements OnInit {
  members: Member[];
  constructor(private memberService: MembersService) { }

  ngOnInit() {
    this.memberService.getAllMembers().subscribe(members => {
      this.members = members;
    }, err => console.log(err));
  }

}

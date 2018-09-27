import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Member } from './model/member.model';
import { Observable } from 'rxjs';

@Injectable()
export class MembersService {
  members: Member[];
  constructor(private http: HttpClient) { }

  getAllMembers() : Observable<Member[]> {
    return this.http.get<Member[]>("https://localhost:5001/api/members");
  }

  getMemberById(id: number): Observable<Member> {
    return this.http.get<Member>("https://localhost:5001/api/members");
  }

  createNewMember(member: Member) {
    this.http.post("https://localhost:5001/api/members", member).subscribe(() => {

    }, error => console.log(error));
  }

  updateMember(member: Member) {
    this.http.put("https://localhost:5001/api/members", member).subscribe(() => {

    }, error => console.log(error));
  }

  deleteMember(id: number) {
    this.http.delete("https://localhost:5001/api/members").subscribe(() => {
      console.log("hooray");
    }, error => console.log(error));
  }
}

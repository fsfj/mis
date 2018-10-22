import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MembersService {
  private baseUrl: string = "http://localhost:8080";
  constructor(private http: HttpClient) { }
  async getAllMembers() {
   return await this.http.get(`${this.baseUrl}/api/members`);
  }
}

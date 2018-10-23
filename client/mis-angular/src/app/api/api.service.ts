import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl: string = "http://localhost:8080"
  constructor(private http: HttpClient) {
    
  }

  api() {
    return this.http.options(this.baseUrl);
  }
}

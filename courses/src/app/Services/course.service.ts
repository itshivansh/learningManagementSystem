import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Course } from '../models/course';
import { RegisterComponent } from '../register/register.component';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  
  private _url="http://localhost:3000/course";
  constructor(private http: HttpClient) { }

   getData(){
     return this.http.get<Course[]>(this._url);
    }

   addUser(data:any){
     return this.http.post<any>(this._url,data);
   }
  
  
}

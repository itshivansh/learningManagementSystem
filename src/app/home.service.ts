import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  // students=[
  //   {id:1,name:"Ambar",description:"Ambar Details",email:"ambar@ara.com"},
  //   {id:2,name:"Utk",description:"Utk Details",email:"utk@email.com"},
  //   {id:3,name:"Sid",description:"Sid Details",email:"Sid@email.com"},
  //   {id:4,name:"PP",description:"PP Details",email:"PP@email.com"}
  // ]

  url = "http://localhost:3000/users"
  constructor(private _http: HttpClient) { }
  public getStudents() {
    return this._http.get(this.url);

  }
  public addStudent(data){
    return this._http.post(this.url,data)
  }
}
  // public createStudents(students:{id:number,name:string,description:string,email:string}){
  //   this.students.push(students);
  // }


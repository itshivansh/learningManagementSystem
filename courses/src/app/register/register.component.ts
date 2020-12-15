import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Course } from '../models/course';
import { CourseService } from '../Services/course.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  alert:boolean;
  constructor(private builder:FormBuilder,private courseServce:CourseService) {}
  user=this.builder.group({
    name:['',Validators.required],
    email:['',Validators.required],
    course:['',Validators.required]
  })
  ngOnInit(): void {

  }
  onSubmit(){
    this.courseServce.addUser(this.user.value).subscribe(data=>{
      alert("Data Successfully updated")
      console.log("Success",data);
    });
  }
}
  

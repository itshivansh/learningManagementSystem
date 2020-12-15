import { Component, OnInit } from '@angular/core';
import { Course } from '../models/course';
import { CourseService } from '../Services/course.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  course:Course;
  constructor(private courseService:CourseService) {
    this.course=new Course();
   }
   public userRegistered:Course[]=[];
  ngOnInit(): void {
    this.courseService.getData().subscribe(data=>{
      console.log(data);
      this.userRegistered=data;
    });
  }

}

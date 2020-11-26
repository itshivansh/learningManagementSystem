import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { HomeService } from '../home.service';


@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.component.html',
  styleUrls: ['./user-create.component.css']
})
export class UserCreateComponent implements OnInit {
  addStudent=new FormGroup({
    name: new FormControl(''),
    description: new FormControl(''),
    email: new FormControl('')
  })

  constructor(private homeservice:HomeService) { }

  ngOnInit() :void{
  }
  createStudent(){
    this.homeservice.addStudent(this.addStudent.value).subscribe((res)=>{
      console.log("Get Data from service",res)
    })
  }

}

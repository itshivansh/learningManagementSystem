import { Component, OnInit } from '@angular/core';
import { HomeService } from '../home.service';

import { User } from '../user/user';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {

  public collection;
  constructor(private homeservice:HomeService) { }

  ngOnInit() :void{
    this.homeservice.getStudents().subscribe((res)=>{
      this.collection=res;
      console.log(this.collection)
    });
  }

}

import { Component, OnInit } from '@angular/core';

import { User } from './user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  // user:User=new User();
  // users:Array<User>=[];
  constructor() { 
    
    // homeService.getStudents().subscribe(res=>{this.users=res},error=>{console.log(error);
    // })
  }

  ngOnInit() {
  }

}

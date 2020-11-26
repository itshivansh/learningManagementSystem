import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import { HomeService } from '../home.service';
import { Name } from './home';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  myname: Name = {
    // name:'Angular Hackathon-Online Courses-LMS'
    name: 'EasiLearn'

  }

  constructor(private homeService:HomeService) { }

  ngOnInit(): void {
  }

}

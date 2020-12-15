import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SignInData } from '../models/signinData';
import { AuthenticationService } from '../Services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  isFormInvalid=false;
  areCredentialsInvalid=false;
  constructor(private authentication:AuthenticationService) { }

  ngOnInit(): void {
  }
  onSubmit(signInForm:NgForm){
    if(!signInForm.valid){
        this.isFormInvalid=true;
        this.areCredentialsInvalid=false;
        return ;
    }
    this.checkCredentials(signInForm);
 }
 private checkCredentials(signInForm:NgForm){
  const signInData=new SignInData(signInForm.value.email,signInForm.value.password);
   if(!this.authentication.authenticate(signInData)){
     this.isFormInvalid=false;
     this.areCredentialsInvalid=true;
   }
 }
}

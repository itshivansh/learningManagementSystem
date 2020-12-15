import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { SignInData } from '../models/signinData';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private readonly mockedUser=new SignInData('meghana13@gmail.com','hello');
  isAuthenticated=false;

  constructor(private router:Router) { }
  
  authenticate(signInData:SignInData):boolean{
    if(this.checkCredenticials(signInData)){
      this.isAuthenticated=true;
      this.router.navigate(['/home'])
      return true;
    }
    this.isAuthenticated=false;
    return false;
  }
  private checkCredenticials(signInData:SignInData):boolean{
    return this.checkMail(signInData.getEmail()) && this.checkPassword(signInData.getPassword())
  }
  private checkMail(email:string):boolean{
    return email===this.mockedUser.getEmail();
  }
  private checkPassword(password:string):boolean{
    return password===this.mockedUser.getPassword();
  }
  logout(){
    this.isAuthenticated=false;
    this.router.navigate(['']);
  }
}

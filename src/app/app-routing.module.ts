import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UserCreateComponent } from './user-create/user-create.component';
import { UserListComponent } from './user-list/user-list.component';


const routes: Routes = [
  {path:'',pathMatch:'full',redirectTo:'/home'},
  {path:'home',component:HomeComponent},
  {path:'user-create',component:UserCreateComponent},
  {path:'user-list',component:UserListComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

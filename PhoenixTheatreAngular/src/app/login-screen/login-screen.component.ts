import { Component} from '@angular/core';
import { FormBuilder } from '@angular/forms';

import { logins } from '../TempLogin';

@Component({
  selector: 'app-login-screen',
  templateUrl: './login-screen.component.html',
  styleUrls: ['./login-screen.component.css']
})
export class LoginScreenComponent{
  showHome:boolean = true;
  showNew:boolean = false;
  showReturn:boolean = false;
  
  getNewCustomer = this.formBuilder.group({
    fname: '',
    lname: '',
    username: '',
    password: ''
  });

  getUserLogin = this.formBuilder.group({
    username: '',
    password: ''
  });
  
  constructor(private formBuilder:FormBuilder) 
  {
    
  }

  ngOnInit(): void {
  }

  ReturnedCus()
  {
    this.showHome = false;
    this.showReturn = true;
  }

  NewCus()
  {
      this.showHome = false;
      this.showNew = true;
  }

  Back()
  {
    this.showHome = true;
    this.showNew = false;
    this.showReturn = false;
  }

  onSubmitCustomer(): void{

  }

  onSubmitUser(): void{

  }
}

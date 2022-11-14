import { Component,OnInit } from '@angular/core';
import {EmployeesService} from './service/employees.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Employees';

  constructor (private employeesService:EmployeesService){

  }
  ngOnInit(): void {
    this.GetAllEmployees();
  }

  GetAllEmployees(){
    this.employeesService.GetAllEmployees()
    .subscribe(
      response => {
        console.log(response);
      }
    );
  }

}

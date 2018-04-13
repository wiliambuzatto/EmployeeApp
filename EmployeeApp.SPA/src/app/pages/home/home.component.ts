import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/Employee.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  employees: any;
  model: any = {};
  createMode = false;
  showObjective = false;
  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.getAll();
  }

  getAll() {
    this.employeeService.getAll().subscribe(response => {
      // console.log(response);
      this.employees = response.json();
      console.log(this.employees);
    });
  }

  create() {
    this.employeeService.create(this.model).subscribe(() => {
      this.getAll();
    }, error => {
      console.log(error);
    });
  }

  delete(id) {
    console.log(id);
    this.employeeService.delete(id).subscribe(() => {
      this.getAll();
    }, error => {
      console.log(error);
    });
  }

  newEmployeeForm() {
    this.createMode = !this.createMode;
    this.showObjective = false;
  }

  cancel() {
    this.createMode = false;
  }

  objectiveToggle() {
    this.showObjective = !this.showObjective;
    (this.showObjective) ? this.createMode = false : this.createMode = true;
  }

}

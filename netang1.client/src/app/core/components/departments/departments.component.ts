import { Component, Input } from '@angular/core';
import { Department } from '../../models/department.model';
import { DepartmentService } from '../../services/department/department.service';

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrl: './departments.component.css'
})
export class DepartmentsComponent {

  departmentList: Department[] = [];
  showToggle: boolean = false;
  constructor(private departmentService: DepartmentService) {}
  ngOnInit(): void {
    
  }
  showAllDepartments():void{
    this.departmentService.getAllDepartments().subscribe(data => {
      this.departmentList = data;
    });
    this.showToggle=true;
  }
  showSingularDepartment(departmentName:string):void{
    this.departmentService.getSingularDepartment(departmentName).subscribe(data => {
      console.log(data);
      this.departmentList = [data];
    });
    this.showToggle=true;
  }

}

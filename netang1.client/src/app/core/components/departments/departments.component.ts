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
  addDepartment(departmentName: string,departmentLocation: string,departmentHeadId: string) {
    this.departmentService.addDepartment(departmentName,departmentLocation,departmentHeadId);
  }
  showAllDepartments():void{
    this.departmentService.getAllDepartments().subscribe(data => {
      this.departmentList = data;
    });
    this.showToggle=true;
  }
  showSingularDepartment(departmentName:string):void{
    if(departmentName){
      this.departmentService.getSingularDepartment(departmentName).subscribe(data => {
        console.log(data);
        this.departmentList = [data];
      });
      this.showToggle=true;
    }
    else{
      alert('Please fill in the department name field.');
    }
  }
  deleteDepartment(departmentId: string) {
    this.departmentService.deleteDepartment(departmentId);
  }
}

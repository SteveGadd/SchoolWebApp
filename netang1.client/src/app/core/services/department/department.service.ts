import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  

  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  addDepartment(departmentName: string, departmentLocation: string, departmentHeadId: string) {
    let department;
    if(departmentHeadId){
      department = {
        name: departmentName,
        location: departmentLocation,
        headProfessorId: departmentHeadId
      };
    }
    else{
      department = {
        name: departmentName,
        location: departmentLocation
      };
    }
    this.http.post<any>(`${this.apiUrl}/api/Department`,department).subscribe(
      (response) => {
      console.log('Add successful', response);
    },
    (error) => {
      console.error('Add failed', error);
    }
    );

    
  }
  getAllDepartments() {
    return this.http.get<any>(`${this.apiUrl}/api/Department`);
  }
  getSingularDepartment(departmentName:string){
    return this.http.get<any>(`${this.apiUrl}/api/Department/${departmentName}`);
  }
  deleteDepartment(departmentId:string){
    console.log(`${this.apiUrl}/api/Department/${departmentId}`);
    this.http.delete<any>(`${this.apiUrl}/api/Department/${departmentId}`).subscribe(
      (response) => {
      console.log('Delete successful', response);
    },
    (error) => {
      console.error('Delete failed', error);
    }
    );
  }
}

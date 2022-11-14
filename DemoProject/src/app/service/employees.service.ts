import {HttpClient } from '@angular/common/http';
import {Injectable} from '@angular/core';
import {Observable } from 'rxjs';
import { Employee } from '../Models/model';


@Injectable ({
    providedIn:'root'
})

export class EmployeesService{

    baseUrl= 'https://localhost:7160/api/Employee';

    constructor(private http: HttpClient){}


    GetAllEmployees(): Observable<Employee[]> {
        return this.http.get<Employee[]>(this.baseUrl);
    }
}
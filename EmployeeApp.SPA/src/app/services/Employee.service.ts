import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';
// import 'rxjs/add/operator/map';

@Injectable()
export class EmployeeService {
    baseUrl = 'http://localhost:5000/api/employee/';

    constructor(private http: Http) { }

    create(model: any) {
        return this.http.post(this.baseUrl + 'create', model, this.requestOption());
    }

    getAll() {
        return this.http.get(this.baseUrl + 'get', this.requestOption());
    }

    delete(id) {
        return this.http.delete(this.baseUrl + 'delete/' + id, this.requestOption());
    }

    private requestOption() {
        const headers = new Headers({'Content-type': 'application/json'});
        return new RequestOptions({headers: headers});
    }

}

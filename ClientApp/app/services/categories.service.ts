import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class CategoriesService {

    constructor(private http: Http, @Inject('ORIGIN_URL') private originUrl: string) { }

    getProducts() {
        return this.http.get(this.originUrl + '/api/categories')
            .map(res => res.json());
    }
}

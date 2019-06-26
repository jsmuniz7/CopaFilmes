import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Movie } from './movie';

const API_URL = 'https://copadosfilmes.azurewebsites.net/api/filmes';

@Injectable({providedIn: 'root'})
export class MovieService {

    constructor(private http: HttpClient){}

    listMovies() : Observable<Movie[]>{
        return this.http
            .get<Movie[]>(API_URL);
    }
}
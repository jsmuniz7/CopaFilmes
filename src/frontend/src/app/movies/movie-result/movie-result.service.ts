import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieResult } from './movie-result';
import { Movie } from '../movie/movie';
import { HttpClient, } from '@angular/common/http';

const API_URL = 'http://localhost:5000/api/championship/result';

@Injectable({providedIn: 'root'})
export class MovieResultService{
    
    constructor(private http: HttpClient) {}
    
    getMovieResultsBySelecion(movies: Movie[]) : Observable<MovieResult[]>{
        console.log(JSON.stringify(movies));

        return this.http
            .post<MovieResult[]>(
                API_URL, 
                JSON.stringify(movies),
                {
                    headers: {'Content-Type':'application/json; charset=utf-8'}   
                }
            );
    }
}
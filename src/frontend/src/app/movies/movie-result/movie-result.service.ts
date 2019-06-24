import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieResult } from './movie-result';
import { Movie } from '../movie/movie';
import { HttpClient } from '@angular/common/http';

const API_URL = 'https://copadosfilmes.azurewebsites.net/api/filmes';

@Injectable({providedIn: 'root'})
export class MovieResultService{
    
    constructor(private http: HttpClient) {}
    
    getMovieResultsBySelecion(movies: Movie[]) : Observable<MovieResult[]>{
        
        return this.http
            .post<MovieResult[]>(API_URL, movies);
    }
}
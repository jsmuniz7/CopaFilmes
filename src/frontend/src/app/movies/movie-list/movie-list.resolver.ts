import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { MovieService } from '../movie/movie.service';

import { Movie } from '../movie/movie';

@Injectable({providedIn: 'root'})
export class MovieListResolver implements Resolve<Observable<Movie[]>>{

    constructor(private movieService: MovieService) {}

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) : Observable<Movie[]>{
        
        return this.movieService.listMovies();
    }
}
import { Component, OnInit, OnChanges } from '@angular/core';
import { Router } from '@angular/router';

import { MovieResultService } from '../movie-result/movie-result.service';
import { MovieResult } from '../movie-result/movie-result';
import { Movie } from '../movie/movie';
import { r3JitTypeSourceSpan } from '@angular/compiler';

@Component({
    selector: 'cf-movie-result-list',
    templateUrl: './movie-result-list.component.html'
})
export class MovieResultListComponent implements OnInit{
    
    
    results: MovieResult[] = [];

    constructor(
        private service: MovieResultService,
        private router: Router) {}
    
    ngOnInit(): void {
        let selectedMovies = JSON.parse(window.localStorage.getItem('selectedMovies')) as Movie[]; 

        if(!selectedMovies || selectedMovies.length != 8)
            this.router.navigate(['']);

        this.service
            .getMovieResultsBySelecion(selectedMovies)
            .subscribe(results => {
                this.results = results
            }, err => {
                console.log(err);
                this.newChampionship();
            }); 
     }

     newChampionship(){
         this.router.navigate(['']);
     }

}
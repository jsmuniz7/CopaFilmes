import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Movie } from '../movie/movie';

const TOTAL_MOVIES = 8;

@Component({
    selector: 'cf-movie-list',
    templateUrl: './movie-list.component.html'
})
export class MovieListComponent implements OnInit{

    movies: Movie[] = [];
    selectedMovies: Movie[] = [];

    totalMoviesToSelect: number = TOTAL_MOVIES;
    selectionCompleted: boolean = false;

    constructor(
        private activatedRoute : ActivatedRoute,
        private router: Router) {}

    ngOnInit(): void {
        this.movies = this.activatedRoute.snapshot.data.movies;
    }

    handleSelectedMovies(movie: Movie){
        let index = this.selectedMovies.indexOf(movie);
        if(index == -1){
            this.selectedMovies.push(movie);
            if(this.selectedMovies.length == this.totalMoviesToSelect)
                this.selectionCompleted = true;
        }
        else{
            this.selectedMovies.splice(index, 1);
            if(this.selectionCompleted)
                this.selectionCompleted = false;
        }
    }

    generateChampionship(){
        window.localStorage.setItem('selectedMovies', JSON.stringify(this.selectedMovies));
        this.router.navigate(['result']);
    }

}
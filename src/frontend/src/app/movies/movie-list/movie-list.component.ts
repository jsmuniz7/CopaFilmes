import { Component, OnInit } from '@angular/core';
import { Movie } from '../movie/movie';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'cf-movie-list',
    templateUrl: './movie-list.component.html'
})
export class MovieListComponent implements OnInit{

    movies: Movie[] = [];

    constructor(private activatedRoute : ActivatedRoute) {}

    ngOnInit(): void {
        this.movies = this.activatedRoute.snapshot.data.movies;
    }

}
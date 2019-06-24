import { Component, Input, OnChanges, ChangeDetectionStrategy, SimpleChanges, Output, EventEmitter } from '@angular/core';
import { Movie } from '../../movie/movie';

@Component({
    selector: 'cf-movies',
    templateUrl: './movies.component.html'
})
export class MoviesComponent implements OnChanges{
    
    @Output() onMovieSelected = new EventEmitter<Movie>();
    @Input() movies: Movie[] = [];
    rows: any[] = [];
    
    ngOnChanges(changes: SimpleChanges): void {
        if(changes.movies)
            this.rows = this.groupColums(this.movies);
    }

    groupColums(movies : Movie[]){
        const newRows = [];

        for(let i = 0; i < movies.length; i+=4){
            newRows.push(movies.slice(i, i+4));
        }
        return newRows;
    }

    movieSelected(movieSelected: Movie){
        this.onMovieSelected.emit(movieSelected);
    }

}
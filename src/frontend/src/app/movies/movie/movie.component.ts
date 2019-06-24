import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Movie } from './movie';

@Component({
    selector: 'cf-movie',
    templateUrl: './movie.component.html'
})
export class MovieComponent{
    
    @Output() onMovieSelected = new EventEmitter<Movie>();
    @Input() movie : Movie;
    @Input() disabled: boolean;

    selected(){
        this.onMovieSelected.emit(this.movie);
    }
}
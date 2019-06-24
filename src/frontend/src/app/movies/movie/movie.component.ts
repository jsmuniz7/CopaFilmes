import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Movie } from './movie';

@Component({
    selector: 'cf-movie',
    templateUrl: './movie.component.html'
})
export class MovieComponent{
    
    @Output() onMovieSelected = new EventEmitter<Movie>();
    @Input() movie : Movie;
    isSelected: boolean = false

    selected(){
        this.isSelected = !this.isSelected;
        console.log(`Movie Selected: ${this.isSelected} ${this.movie.titulo} ${this.movie.nota}`)
        this.onMovieSelected.emit(this.movie);
    }
}
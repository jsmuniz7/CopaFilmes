import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Movie } from './movie';
import { FormControl, CheckboxControlValueAccessor, FormsModule } from '@angular/forms';

@Component({
    selector: 'cf-movie',
    templateUrl: './movie.component.html'
})
export class MovieComponent{
    
    @Output() onMovieSelected = new EventEmitter<Movie>();
    @Input() movie : Movie;
    @Input() disabled: boolean;


    selected(element : HTMLInputElement){
        if(this.disabled){
            if(!element.checked){
                this.onMovieSelected.emit(this.movie);
            }
            element.checked = false;
        }else {
            this.onMovieSelected.emit(this.movie);
        }
    }
}
import { Component, Input } from '@angular/core';


@Component({
    selector: 'cf-movies-selected',
    templateUrl: './movies-selected.component.html',
    styleUrls: ['./movies-selected.component.css']
})
export class MoviesSelectedComponent {
    
    @Input() totalMovies: number = 0;
    @Input() selectedMovies: number;
}
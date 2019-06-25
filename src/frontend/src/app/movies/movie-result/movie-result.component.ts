import { Component, Input } from '@angular/core';

@Component({
    selector: 'cf-movie-result',
    templateUrl: './movie-result.component.html',
    styleUrls: ['./movie-result.component.css']
})
export class MovieResultComponent{

    @Input() moviePosition: string = '';
    @Input() movieTitle: string = '';
    
}
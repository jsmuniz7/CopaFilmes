import { Component, Input } from '@angular/core';
import { Movie } from 'src/app/movies/movie/movie';

@Component({
    selector: 'cf-confirm-button',
    templateUrl: './confirm-button.component.html',
    styleUrls: [ './confirm-button.component.css'] 
})
export class ConfirmButtonComponent {

    @Input() buttonText: string;
    @Input() disabled : boolean;

}
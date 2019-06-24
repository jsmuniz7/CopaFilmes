import { Component, OnInit, Input } from '@angular/core';

@Component({
    selector: 'cf-movie',
    templateUrl: './movie.component.html'
})
export class MovieComponent{
    
    @Input() title = 'Teste';
    @Input() year = '2001';

}
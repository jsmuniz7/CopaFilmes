import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms';

import { MovieModule } from './movie/movie.module';
import { MovieListModule } from './movie-list/movie-list.module';
import { MovieResultListModule } from './movie-result-list/movie-result-list.module';

@NgModule({
    imports:[
        MovieModule,
        MovieListModule,
        ReactiveFormsModule,
        MovieResultListModule
    ]
})
export class MoviesModule {

}
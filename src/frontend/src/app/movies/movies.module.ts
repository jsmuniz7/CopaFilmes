import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms';

import { MovieModule } from './movie/movie.module';
import { MovieListModule } from './movie-list/movie-list.module';
import { MovieResultListModule } from './movie-result-list/movie-result-list.module';
import { MovieResultModule } from './movie-result/movie-result.module';

@NgModule({
    imports:[
        MovieModule,
        MovieListModule,
        ReactiveFormsModule,
        MovieResultListModule,
        MovieResultModule
    ]
})
export class MoviesModule {

}
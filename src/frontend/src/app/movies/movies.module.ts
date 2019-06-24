import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms';
import { MovieModule } from './movie/movie.module';
import { MovieListModule } from './movie-list/movie-list.module';
import { MovieResultModule } from './movie-result/movie-result.module';

@NgModule({
    imports:[
        MovieModule,
        MovieListModule,
        MovieResultModule,
        ReactiveFormsModule
    ]
})
export class MoviesModule {

}
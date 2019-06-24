import { NgModule } from '@angular/core';
import { MovieModule } from './movie/movie.module';
import { MovieListModule } from './movie-list/movie-list.module';
import { MovieResultModule } from './movie-result/movie-result.module';

@NgModule({
    imports:[
        MovieModule,
        MovieListModule,
        MovieResultModule
    ]
})
export class MoviesModule {

}
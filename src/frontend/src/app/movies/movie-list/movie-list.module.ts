import { NgModule } from '@angular/core';
import { MovieListComponent } from './movie-list.component';
import { CommonModule } from '@angular/common';
import { MovieModule } from '../movie/movie.module';
import { MoviesComponent } from './movies/movies.component';
import { CoreModule } from 'src/app/core/core.module';

@NgModule({
    declarations: [
        MovieListComponent,
        MoviesComponent
    ],
    imports: [
        CommonModule,
        MovieModule,
        CoreModule
    ]
})
export class MovieListModule{

}
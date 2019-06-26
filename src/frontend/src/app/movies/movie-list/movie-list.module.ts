import { NgModule } from '@angular/core';
import { MovieListComponent } from './movie-list.component';
import { CommonModule } from '@angular/common';
import { MovieModule } from '../movie/movie.module';
import { MoviesComponent } from './movies/movies.component';
import { CoreModule } from 'src/app/core/core.module';
import { MoviesSelectedComponent } from './movies-selected/movies-selected.component';

@NgModule({
    declarations: [
        MovieListComponent,
        MoviesComponent,
        MoviesSelectedComponent
    ],
    imports: [
        CommonModule,
        MovieModule,
        CoreModule
    ]
})
export class MovieListModule{

}
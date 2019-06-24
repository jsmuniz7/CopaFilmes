import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MovieListComponent } from './movies/movie-list/movie-list.component';
import { MovieListResolver } from './movies/movie-list/movie-list.resolver';
import { MovieResultComponent } from './movies/movie-result/movie-result.component';

const routes : Routes = [
    { 
        path: '', 
        component: MovieListComponent,
        resolve: {
            movies: MovieListResolver
        }
    },
    { 
        path: 'result', 
        component: MovieResultComponent,
    }
]

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutingModule {

}
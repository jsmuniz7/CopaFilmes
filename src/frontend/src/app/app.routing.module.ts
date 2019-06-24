import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MovieListComponent } from './movies/movie-list/movie-list.component';
import { MovieListResolver } from './movies/movie-list/movie-list.resolver';
import { MovieResultListComponent } from './movies/movie-result-list/movie-result-list.component';

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
        component: MovieResultListComponent,
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
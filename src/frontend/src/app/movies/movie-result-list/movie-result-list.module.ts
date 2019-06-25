import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from 'src/app/core/core.module';
import { MovieResultListComponent } from './movie-result-list.component';
import { MovieResultModule } from '../movie-result/movie-result.module';

@NgModule({
    declarations: [ MovieResultListComponent],
    imports: [
        CommonModule,
        CoreModule,
        MovieResultModule
    ]
})
export class MovieResultListModule{

}
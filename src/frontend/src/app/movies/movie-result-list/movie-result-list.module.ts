import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from 'src/app/core/core.module';
import { MovieResultListComponent } from './movie-result-list.component';

@NgModule({
    declarations: [ MovieResultListComponent],
    imports: [
        CommonModule,
        CoreModule
    ]
})
export class MovieResultListModule{

}
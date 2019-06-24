import { NgModule } from '@angular/core';
import { MovieResultComponent } from './movie-result.component';
import { CommonModule } from '@angular/common';
import { CoreModule } from 'src/app/core/core.module';

@NgModule({
    declarations: [ MovieResultComponent],
    imports: [
        CommonModule,
        CoreModule
    ]
})
export class MovieResultModule{

}
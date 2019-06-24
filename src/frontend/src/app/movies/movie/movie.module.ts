import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { MovieComponent } from './movie.component';



@NgModule({
    declarations: [MovieComponent],
    imports: [
        CommonModule,
        HttpClientModule
    ],
    exports: [MovieComponent]
})
export class MovieModule{

}
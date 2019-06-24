import { NgModule } from '@angular/core';
import { HeaderComponent } from './header/header.component';
import { ConfirmButtonComponent } from './confirm-button/confirm-button.component';

@NgModule({
    declarations: [
        HeaderComponent,
        ConfirmButtonComponent
    ],
    exports: [
        HeaderComponent,
        ConfirmButtonComponent
    ]
})
export class CoreModule{

}
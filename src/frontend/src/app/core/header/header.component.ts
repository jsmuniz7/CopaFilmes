import { Component, Input } from '@angular/core';

@Component({
    selector: 'cf-header',
    templateUrl: './header.component.html'
})
export class HeaderComponent{

    @Input() appTitle: string;
    @Input() pageTitle: string;
    @Input() pageMessage: string;

}
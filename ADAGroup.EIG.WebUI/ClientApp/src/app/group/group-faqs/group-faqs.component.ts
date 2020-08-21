import { Component, OnInit } from '@angular/core';
import { EIGService } from '../eig.service';

@Component({
    selector: 'app-group-faqs',
    templateUrl: './group-faqs.component.html',
    styleUrls: ['./group-faqs.component.css']
})
export class GroupFAQsComponent implements OnInit {

    constructor(private eigSvc: EIGService) { }

    ngOnInit() {

        // subscribe to acknowledge FAQ edit
        this.eigSvc.editFAQConfirmed$.subscribe(faqId => { });
    }

}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EIGService } from '../eig.service';

@Component({
    selector: 'app-group-faqform',
    templateUrl: './group-faqform.component.html',
    styleUrls: ['./group-faqform.component.css']
})
export class GroupFAQFormComponent implements OnInit {

    groupId: string;

    constructor(private avRoute: ActivatedRoute, private eigSvc: EIGService) {

        // get the group id in parameter
        let gId: string = this.avRoute.snapshot.params['groupId'];
        if (gId) {
            this.groupId = gId;
        }
    }

    ngOnInit() {
    }

}

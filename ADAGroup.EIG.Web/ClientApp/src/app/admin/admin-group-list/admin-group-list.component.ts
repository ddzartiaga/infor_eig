import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { EIGShortInfo } from '../../models/eig-short-info';
import { EIGService } from '../../services/eig.service';

@Component({
    selector: 'app-admin-group-list',
    templateUrl: './admin-group-list.component.html',
    styleUrls: ['./admin-group-list.component.css']
})
export class AdminGroupListComponent implements OnInit {

    groupsList$: Observable<EIGShortInfo[]>;

    constructor(private eigService: EIGService) { }

    ngOnInit() {
        
    }

    

}

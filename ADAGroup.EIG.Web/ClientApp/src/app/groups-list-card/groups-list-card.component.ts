import { Component, OnInit } from '@angular/core';
import { of } from 'rxjs';

@Component({
    selector: 'app-groups-list-card',
    templateUrl: './groups-list-card.component.html',
    styleUrls: ['./groups-list-card.component.css']
})
export class GroupsListCardComponent implements OnInit {

    itemsInRow = 3;
    list = Array.from(Array(14).keys());
    itemInRowRange = Array.from(Array(this.itemsInRow).keys());
    items = of(this.list);

    name: string = 'Hello';

    constructor() { }

    ngOnInit() {
        this.loadGroups();
    }

    loadGroups() {
    }

}

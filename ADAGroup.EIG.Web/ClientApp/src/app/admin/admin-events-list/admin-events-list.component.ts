import { Component, OnInit } from '@angular/core';
import { EventsService } from '../../services/events.service';
import { Observable } from 'rxjs';
import { EventList } from '../../models/event-list';

@Component({
    selector: 'app-admin-events-list',
    templateUrl: './admin-events-list.component.html',
    styleUrls: ['./admin-events-list.component.css']
})
export class AdminEventsListComponent implements OnInit {

    events$: Observable<EventList[]>;

    constructor(private eventsService: EventsService) { }

    ngOnInit() {
        this.getEventsList();
    }

    getEventsList() {
        this.events$ = this.eventsService.getEventsList();
    }
}

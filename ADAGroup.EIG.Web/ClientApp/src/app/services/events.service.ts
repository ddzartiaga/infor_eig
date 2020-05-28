import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { EventList } from '../models/event-list';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class EventsService {

    baseApiUrl: string;

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json; charset=utf-8'
        })
    };

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseApiUrl = baseUrl + '/api/events/';
    }

    getEventsList(): Observable<EventList[]> {
        return this.http.get<EventList[]>(this.baseApiUrl + 'EventsForList')
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    errorHandler(error) {
        let errorMessage = '';
        if (error.error instanceof ErrorEvent) {
            // Get client-side error
            errorMessage = error.error.message;
        } else {
            // Get server-side error
            errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
        }
        console.log(errorMessage);
        return throwError(errorMessage);
    }
}

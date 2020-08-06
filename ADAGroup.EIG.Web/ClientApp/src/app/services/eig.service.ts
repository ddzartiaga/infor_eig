import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { InterestGroup } from '../models/eig';
import { EIGShortInfo } from '../models/eig-short-info';

@Injectable({
    providedIn: 'root'
})
export class EIGService {

    EIGApiBaseUrl: string;
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json; charset=utf-8'
        })
    };
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.EIGApiBaseUrl = baseUrl + 'api/groups/';
    }


    getGroupInfo(groupId: string): Observable<InterestGroup> {
        const url = this.EIGApiBaseUrl + 'Details/?groupId=' + groupId;

        return this.http.get<InterestGroup>(url).pipe(retry(1), catchError(this.errorHandler));
    }

    upsertGroup(group: InterestGroup): Observable<string> {
        let url: string = '';

        if (group.groupId == null) {
            url = this.EIGApiBaseUrl + 'NewGroup';
            console.log(url);
            return this.http.post<string>(url, JSON.stringify(group), this.httpOptions)
                .pipe(
                    retry(1),
                    catchError(this.errorHandler)
                );
        } else {
            url = this.EIGApiBaseUrl + 'UpdateGroup';
            console.log(url);
            return this.http.put<string>(url, JSON.stringify(group), this.httpOptions)
                .pipe(
                    retry(1),
                    catchError(this.errorHandler)
                );
        }
    }

    addFAQ(InterestGroup): Observable<InterestGroup> {
        const url = this.EIGApiBaseUrl + 'NewGroup';
        console.log(JSON.stringify(InterestGroup));

        return this.http.post<InterestGroup>(url, JSON.stringify(InterestGroup), this.httpOptions)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }


    errorHandler(error) {
        console.log(error);

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
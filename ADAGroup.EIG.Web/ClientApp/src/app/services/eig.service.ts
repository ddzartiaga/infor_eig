import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { EIG } from '../models/eig';
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

    getGroupsList(): Observable<EIGShortInfo[]> {

        return this.http.get<EIGShortInfo[]>(this.EIGApiBaseUrl + 'GroupsList')
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    getEIGDetail(groupId: string): Observable<EIG> {
        const url = this.EIGApiBaseUrl + 'Details/?groupId=' + groupId;
 

        return this.http.get<EIG>(url)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    saveEIGDetails(EIG): Observable<EIG> {
        const url = this.EIGApiBaseUrl + 'Upsert';
        console.log(JSON.stringify(EIG));

        return this.http.post<EIG>(url, JSON.stringify(EIG), this.httpOptions)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    updateEIG(groupId: number, EIG): Observable<EIG> {
        return this.http.put<EIG>(this.EIGApiBaseUrl + groupId, JSON.stringify(EIG), this.httpOptions)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    deleteEIG(groupId: number): Observable<EIG> {
        return this.http.delete<EIG>(this.EIGApiBaseUrl + groupId)
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
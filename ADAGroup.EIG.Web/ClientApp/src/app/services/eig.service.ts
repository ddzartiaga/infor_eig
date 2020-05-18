import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { EIG } from '../models/eig';

@Injectable({
    providedIn: 'root'
})
export class EIGService {

    myAppUrl: string;
    myApiUrl: string;
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json; charset=utf-8'
        })
    };
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.myAppUrl = baseUrl;
        this.myApiUrl = 'api/EIGs/';
    }

    getEIGs(): Observable<EIG[]> {
        
        return this.http.get<EIG[]>(this.myAppUrl + this.myApiUrl + 'All') 
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    getEIG(groupId: number): Observable<EIG> {
        return this.http.get<EIG>(this.myAppUrl + this.myApiUrl + groupId)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    saveEIG(EIG): Observable<EIG> {
        return this.http.post<EIG>(this.myAppUrl + this.myApiUrl, JSON.stringify(EIG), this.httpOptions)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    updateEIG(groupId: number, EIG): Observable<EIG> {
        return this.http.put<EIG>(this.myAppUrl + this.myApiUrl + groupId, JSON.stringify(EIG), this.httpOptions)
            .pipe(
                retry(1),
                catchError(this.errorHandler)
            );
    }

    deleteEIG(groupId: number): Observable<EIG> {
        return this.http.delete<EIG>(this.myAppUrl + this.myApiUrl + groupId)
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
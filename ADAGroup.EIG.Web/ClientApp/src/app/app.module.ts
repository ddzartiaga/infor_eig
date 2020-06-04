import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { EIGService } from './services/eig.service';
import { AdminComponent } from './admin/admin.component';
import { AdminGroupListComponent } from './admin/admin-group-list/admin-group-list.component';
import { AdminGroupMgmtComponent } from './admin/admin-group-mgmt/admin-group-mgmt.component';
import { AdminUsersListComponent } from './admin/admin-users-list/admin-users-list.component';
import { AdminEventsListComponent } from './admin/admin-events-list/admin-events-list.component';
import { AdminEventMgmtComponent } from './admin/admin-event-mgmt/admin-event-mgmt.component';
import { GroupsPageComponent } from './groups-page/groups-page.component';
import { EventsPageComponent } from './events-page/events-page.component';
import { ViewEventDetailsComponent } from './view-event-details/view-event-details.component';
import { ViewGroupDetailsComponent } from './view-group-details/view-group-details.component';
import { GroupsListCardComponent } from './groups-list-card/groups-list-card.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        AdminComponent,
        AdminGroupListComponent,
        AdminGroupMgmtComponent,
        AdminUsersListComponent,
        AdminEventsListComponent,
        AdminEventMgmtComponent,
        GroupsPageComponent,
        EventsPageComponent,
        ViewEventDetailsComponent,
        ViewGroupDetailsComponent,
        GroupsListCardComponent,

    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full' },
            { path: 'groups-page', component: GroupsPageComponent },
            { path: 'view-group', component: ViewGroupDetailsComponent },
            { path: 'events-page', component: EventsPageComponent },
            { path: 'view-event', component: ViewEventDetailsComponent },
            { path: 'admin', component: AdminComponent },
            { path: 'new-eig', component: AdminGroupMgmtComponent },
            { path: 'update-eig/:groupId', component: AdminGroupMgmtComponent },
            { path: 'new-event', component: AdminEventMgmtComponent },
            { path: 'update-event/:eventId', component: AdminEventMgmtComponent },
        ]),
    ],
    providers: [EIGService],
    bootstrap: [AppComponent]
})
export class AppModule { }

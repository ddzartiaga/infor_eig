import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AdminModule } from './admin/admin.module';
import { GroupModule } from './group/group.module';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { NewGroupPageComponent } from './group/new-group-page/new-group-page.component';
import { ManageGroupPageComponent } from './group/manage-group-page/manage-group-page.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full' },
            { path: 'admin', component: AdminPageComponent },
            { path: 'new-group', component: NewGroupPageComponent },
            { path: 'manage-group/:groupId', component: ManageGroupPageComponent },
        ]),
        AdminModule,
        GroupModule,
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }

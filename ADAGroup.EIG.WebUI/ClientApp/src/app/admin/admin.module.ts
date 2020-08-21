import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { UsersListComponent } from './users-list/users-list.component';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { GroupModule } from '../group/group.module';


@NgModule({
    declarations: [
        AdminPageComponent,
        UsersListComponent,
    ],
    imports: [
        RouterModule,
        CommonModule,
        GroupModule,
    ]
})
export class AdminModule { }

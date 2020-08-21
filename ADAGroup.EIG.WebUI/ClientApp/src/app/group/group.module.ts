import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { LogosListComponent } from './logos-list/logos-list.component';
import { NewGroupPageComponent } from './new-group-page/new-group-page.component';
import { LogoUpsertComponent } from './logo-upsert/logo-upsert.component';
import { GroupInfoUpsertComponent } from './group-info-upsert/group-info-upsert.component';
import { EIGService } from './eig.service';
import { ManageGroupPageComponent } from './manage-group-page/manage-group-page.component';
import { GroupFAQsComponent } from './group-faqs/group-faqs.component';
import { GroupFAQFormComponent } from './group-faqform/group-faqform.component';
import { GroupGalleriesComponent } from './group-galleries/group-galleries.component';

@NgModule({
    declarations: [
        LogosListComponent,
        NewGroupPageComponent,
        LogoUpsertComponent,
        GroupInfoUpsertComponent,
        ManageGroupPageComponent,
        GroupFAQsComponent,
        GroupFAQFormComponent,
        GroupGalleriesComponent
    ],
    exports: [LogosListComponent],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
    ],
    providers: [EIGService]
})
export class GroupModule { }

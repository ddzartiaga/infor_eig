import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { InterestGroup } from '../../models/eig';
import { EIGService } from '../eig.service';

@Component({
  selector: 'app-group-info-upsert',
  templateUrl: './group-info-upsert.component.html',
  styleUrls: ['./group-info-upsert.component.css']
})
export class GroupInfoUpsertComponent implements OnInit {

    groupId: string;
    pageMode: string;
    groupInfo: InterestGroup;

    groupInfoForm: FormGroup;
    nameCtrl: string;
    goalAndPurposeCtrl: string;
    missionCtrl: string;


    constructor(private avRoute: ActivatedRoute, private router: Router, private eigSvc: EIGService, private formBuilder: FormBuilder) {

        // get the group id in parameter
        let gId: string = this.avRoute.snapshot.params['groupId'];
        if (gId) {
            this.groupId = gId;
        }

        // set initial page mode
        this.pageMode = 'new';

        // set group info form validators
        this.nameCtrl = 'name';
        this.goalAndPurposeCtrl = 'goalpurpose';
        this.missionCtrl = 'mission';

        this.groupInfoForm = this.formBuilder.group({
            groupId: gId,
            name: ['', [Validators.required]],
            goalpurpose: ['', [Validators.required]],
            mission: ['', [Validators.required]],
        })
    }

    ngOnInit() {

        // get group information if groupId is not null
        if (this.groupId != null) {
            // set page mode
            this.pageMode = 'update';

            this.loadGroupInfo();
        }
    }

    loadGroupInfo() {
        // load interest group info from API
        this.eigSvc.getGroupInfo(this.groupId).subscribe(grp => (
            this.groupInfo = grp,

            this.groupInfoForm.controls[this.nameCtrl].setValue(grp.name),
            this.groupInfoForm.controls[this.goalAndPurposeCtrl].setValue(grp.goalAndPurpose),
            this.groupInfoForm.controls[this.missionCtrl].setValue(grp.mission)
        ));
    }

    saveInfo() {
        console.log('Saving group info..');
        if (!this.groupInfoForm.valid) {
            return;
        }

        let igroup: InterestGroup = {
            groupId: this.groupId,
            name: this.groupInfoForm.get(this.nameCtrl).value,
            goalAndPurpose: this.groupInfoForm.get(this.goalAndPurposeCtrl).value,
            mission: this.groupInfoForm.get(this.missionCtrl).value,
        }

        this.eigSvc.upsertGroup(igroup).subscribe(grpId => {

            console.log('Group info saved with ID: ' + grpId);

            this.groupId = grpId;

            if (this.pageMode == 'new') {
                // redirect to manage group page
                const url = '/manage-group/' + this.groupId;
                this.router.navigateByUrl(url);
            } else {
                // reload page
                this.loadGroupInfo();
            }
            
        });
    }

}

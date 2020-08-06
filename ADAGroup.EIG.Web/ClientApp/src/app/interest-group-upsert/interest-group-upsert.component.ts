import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, Route } from '@angular/router';
import { EIGService } from '../services/eig.service';
import { InterestGroup } from '../models/eig';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
    selector: 'app-interest-group-upsert',
    templateUrl: './interest-group-upsert.component.html',
    styleUrls: ['./interest-group-upsert.component.css']
})
export class InterestGroupUpsertComponent implements OnInit {

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
        console.log('Save Info');
        if (!this.groupInfoForm.valid) {
            return;
        }

        let igroup: InterestGroup = {
            groupId: this.groupId,
            name: this.groupInfoForm.get(this.nameCtrl).value,
            goalAndPurpose: this.groupInfoForm.get(this.goalAndPurposeCtrl).value,
            mission: this.groupInfoForm.get(this.missionCtrl).value,
        }

        console.log('Saving group info..');

        this.eigSvc.upsertGroup(igroup).subscribe(grpId => {
            console.log('Group info saved!');
            this.groupId = grpId;
            //this.router.(['/admin']);

            // reload parts
            this.loadGroupInfo();
        });
    }

}

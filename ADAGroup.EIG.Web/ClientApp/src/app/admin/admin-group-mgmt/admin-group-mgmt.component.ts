import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EIGService } from '../../services/eig.service';
import { InterestGroup } from '../../models/eig';

@Component({
    selector: 'app-admin-group-mgmt',
    templateUrl: './admin-group-mgmt.component.html',
    styleUrls: ['./admin-group-mgmt.component.css']
})
export class AdminGroupMgmtComponent implements OnInit {

    form: FormGroup;
    actionType: string;

    nameCtrl: string;
    purposeCtrl: string;
    missionCtrl: string;
    reqCtrl: string;


    groupId: string;
    exRecord: InterestGroup;
    errorMessage: string;



    constructor(private eigService: EIGService, private formBuilder: FormBuilder, private avRoute: ActivatedRoute, private router: Router) {
        const idParam = 'groupId';

        this.actionType = 'add';
        this.nameCtrl = 'name';
        this.purposeCtrl = 'purpose';
        this.missionCtrl = 'mission';
        this.reqCtrl = 'requirements';

        // set the groupId from parameter
        if (this.avRoute.snapshot.params[idParam]) {
            this.groupId = this.avRoute.snapshot.params[idParam];
        }

        // sets the intial value and validators
        this.form = this.formBuilder.group({
            groupId: null,
            name: ['', [Validators.required]],
            purpose: ['', [Validators.required]],
            mission: ['', [Validators.required]],
            requirements: [''],
        })

    }

    ngOnInit() {
        console.log(this.groupId);

        if (this.groupId != null) {

            this.actionType = 'edit';

            // get the group details and set the form
            //this.eigService.getEIGDetail(this.groupId).subscribe(data => (
            //        this.exRecord = data,
            //        this.form.controls[this.nameCtrl].setValue(data.name),
            //        this.form.controls[this.purposeCtrl].setValue(data.goalAndPurpose),
            //        this.form.controls[this.missionCtrl].setValue(data.mission),
            //        this.form.controls[this.reqCtrl].setValue(data.requirements)
            //    ));
        }
    }

    save() {
        if (!this.form.valid) {
            return;
        }

        let igroup: InterestGroup = {
            groupId: this.groupId,
            name: this.form.get(this.nameCtrl).value,
            goalAndPurpose: this.form.get(this.purposeCtrl).value,
            mission: this.form.get(this.missionCtrl).value,
        }

        console.log('Saving EIG details..');

        //this.eigService.saveEIGDetails(igroup).subscribe(data => {
        //    this.router.navigate(['/admin']);
        //});
    }

    cancel() {
        this.router.navigate(['/admin']);
    }

}

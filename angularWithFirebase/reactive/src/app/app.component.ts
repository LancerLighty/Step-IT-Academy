
import { Component } from '@angular/core';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'reactive';
  jobForm!:FormGroup
  save:boolean = false
  constructor(private fb:FormBuilder) { 
    this.jobForm = this.fb.group({
      jobs:this.fb.array([])
    })
  }
  getJobs(){
    return this.jobForm.get("jobs") as FormArray;
  }
  newJob(){
    this.save = true
    return this.fb.group({
      companyName:'',
      companyDescription:'',
      workExps:this.fb.array([])
    })
  }
  getWorkExps(jobIndex:number){
    return this.getJobs().at(jobIndex).get("workExps") as FormArray;
  }
  newWorkExps(){
    return this.fb.group({
      position:'',
      startDate:'',
      endDate:''
    })
  }
  addNewJob(){
    return this.getJobs().push(this.newJob())
  }
  deleteJob(jobIndex:number){
    this.save = false
    return this.getJobs().removeAt(jobIndex)
  }
  addNewExp(jobIndex:number){
    return this.getWorkExps(jobIndex).push(this.newWorkExps())
  }
  deleteWorkExps(jobIndex:number, expIndex:number){
    return this.getWorkExps(jobIndex).removeAt(expIndex)
  }
  onFormSubmit(){
    if (this.jobForm.valid && this.allFieldsEntered()) {
      console.log(this.jobForm.value)
    }
  }
  allFieldsEntered() {
    const jobs = this.jobForm.get('jobs') as FormArray;
  
    for (let i = 0; i < jobs.length; i++) {
      const job = jobs.at(i) as FormGroup;
  
      const companyName = job.get('companyName')?.value;
      const companyDescription = job.get('companyDescription')?.value;
      const workExps = job.get('workExps') as FormArray;
  
      if (!companyName || !companyDescription || !workExps.length) {
        return false;
      }
  
      for (let j = 0; j < workExps.length; j++) {
        const workExp = workExps.at(j) as FormGroup;
  
        const position = workExp.get('position')?.value;
        const startDate = workExp.get('startDate')?.value;
        const endDate = workExp.get('endDate')?.value;
  
        if (!position || !startDate || !endDate) {
          return false;
        }
      }
    }
    return true
  }
}


import {inject} from "aurelia-framework";
import {Company} from "../../models/company";
import {AdminService} from "../../services/admin-service";

@inject(AdminService)
export class CompanyDetail {

   company: Company;

   constructor(private _adminSvc: AdminService) { }

   activate(params) {
      return this._adminSvc.getCompany(params.id).then(res => this.company=res);
   }

   goBack(){
      window.history.back();
   }
}
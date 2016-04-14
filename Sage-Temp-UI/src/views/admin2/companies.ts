import {inject} from "aurelia-framework";
import {Company} from "../../models/company";
import {AdminService} from "../../services/admin-service";

@inject(AdminService)
export class Companies {
   adminSvc: AdminService;
   companies: Company[];
   selectedCompany: Company;

   constructor(adminSvc: AdminService){
      this.adminSvc = adminSvc;
   }
   
   activate() {
      return this.adminSvc.getCompanies().then(response => {this.companies = response;});
   }
   
   getUrl(company: Company) : string {
       return window["Globals"].baseUrl + "admin/edit/" + company.id;
   }

}


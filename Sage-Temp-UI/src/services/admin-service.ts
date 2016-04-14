import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-fetch-client";
import {Company} from "../models/company";
import * as _ from "underscore";

@inject(HttpClient)
export class AdminService {
   http: HttpClient;

   constructor(http: HttpClient) {
      if (!http.isConfigured) {
         http.configure(config => {
            config
               .useStandardConfiguration()
               .withBaseUrl(window["Globals"].baseUrl + "api/adminapi/");
         });
      }

      this.http = http;
   }

   getCompanies(): Promise<Company[]> {
      return this.http.fetch("getcompanies")
         .then(response => response.json())
         .then(companies => {
            var retVal: Company[] = [];
            _.each(companies, c => {
               // var company = new Company();
               // company.addressLine1 = c.addressLine1;
               // company.addressLine2 = c.addressLine2;
               // company.city = c.city;
               // company.createdDateUtc = c.createdDateUtc;
               // company.id = c.id;
               // company.isDisabled = c.isDisabled;
               // company.isTestCompany = c.isTestCompany;
               // company.name = c.name;
               // company.notes = c.notes;
               // company.phone = c.phone;
               // company.primaryContact = c.primaryContact;
               // company.state = c.state;
               // company.zip = c.zip;
               //retVal.push(company);
               retVal.push(<Company>c);
            });
            return retVal;
         });
   }

   getCompany(id: number): Promise<Company> {
      return this.http.fetch(`getcompany/${id}`)
         .then(res => res.json())
         .then(company => {
            return <Company>company;
         });
   }
}
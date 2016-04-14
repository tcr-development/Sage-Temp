import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-fetch-client";
import {Company} from "../models/company";
import * as _ from "underscore";

@inject(HttpClient)
export class AdminService {
   http: HttpClient;
   private _companies: Company[] = [];

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

      if (this._companies.length > 0) {
         return Promise.resolve(this._companies);
      } else {
         return this.http.fetch("getcompanies")
            .then(response => response.json())
            .then(companies => {
               this._companies = [];
               _.each(companies, c => {
                  this._companies.push(<Company>c);
               });
               return this._companies;
            });   
      }
      
   }

   getCompany(id: number): Promise<Company> {
      return this.http.fetch(`getcompany/${id}`)
         .then(res => res.json())
         .then(company => {
            return <Company>company;
         });
   }
}
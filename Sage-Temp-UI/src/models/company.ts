/**
 * Created by davidk on 4/7/2016.
 */
export class Company {
   id: number;
   name: string;
   addressLine1: string;
   addressLine2: string;
   city: string;
   companyTypeCd: number;
   createdDateUtc: Date;
   isDisabled: boolean;
   isTestCompany: boolean;
   notes: string;
   phone: string;
   primaryContact: string;
   state: string;
   zip: string;
   license: CompanyLicense;
}

export class CompanyLicense {
    allow408b2: boolean;
    allowFundList: boolean;
    allowModels: boolean;
    allowPlanReview: boolean;
    allowProposal: boolean;
    allowSchwabCustody: boolean;
    allowSchwabTrust: boolean;
    allowSgnMidAtlantic: boolean;
    maxPlans: number;
    maxPlatforms: number;
    maxUsers: number;
}
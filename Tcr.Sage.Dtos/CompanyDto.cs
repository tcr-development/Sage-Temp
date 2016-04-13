using System;
using Tcr.Sage.Shared;

namespace Tcr.Sage.Dtos {
   public class CompanyDto {
      public int Id { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public string City { get; set; }
      public CompanyType CompanyTypeCd { get; set; }
      public DateTime CreatedDateUtc { get; set; }
      public bool IsDisabled { get; set; }
      public bool IsTestCompany { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public string Phone { get; set; }
      public string PrimaryContact { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }
      public CompanyLicenseDto License { get; set; }
   }
}
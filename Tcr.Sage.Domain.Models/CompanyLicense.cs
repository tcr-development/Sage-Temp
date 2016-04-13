namespace Tcr.Sage.Domain.Models {
   public partial class CompanyLicense {
      public int CompanyId { get; set; }
      public bool Allow408b2 { get; set; }
      public bool AllowFundList { get; set; }
      public bool AllowModels { get; set; }
      public bool AllowPlanReview { get; set; }
      public bool AllowProposal { get; set; }
      public bool AllowSchwabCustody { get; set; }
      public bool AllowSchwabTrust { get; set; }
      public bool AllowSgnMidAtlantic { get; set; }
      public short MaxPlans { get; set; }
      public byte MaxPlatforms { get; set; }
      public short MaxUsers { get; set; }

      public virtual Company Company { get; set; }
   }
}

using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class Company {
      public Company() {
         Benchmark = new HashSet<Benchmark>();
         FeeSchedule = new HashSet<FeeSchedule>();
         FileMaster = new HashSet<FileMaster>();
         FundDetail = new HashSet<FundDetail>();
         FundList = new HashSet<FundList>();
         InvestmentProduct = new HashSet<InvestmentProduct>();
         PlanFeeSchedule = new HashSet<PlanFeeSchedule>();
         PlanFile = new HashSet<PlanFile>();
         PlanGroup = new HashSet<PlanGroup>();
         PlanMaster = new HashSet<PlanMaster>();
         Proposal = new HashSet<Proposal>();
         ReportPiece = new HashSet<ReportPiece>();
         ReportRequest = new HashSet<ReportRequest>();
         ReportTemplate = new HashSet<ReportTemplate>();
         Review = new HashSet<Review>();
         ScoringTool = new HashSet<ScoringTool>();
         TradingPlatform = new HashSet<TradingPlatform>();
         User = new HashSet<User>();
      }

      public int Id { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public string City { get; set; }
      public byte CompanyTypeCd { get; set; }
      public DateTime CreatedDateUtc { get; set; }
      public bool IsDisabled { get; set; }
      public bool IsTestCompany { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public string Phone { get; set; }
      public string PrimaryContact { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }

      public virtual ICollection<Benchmark> Benchmark { get; set; }
      public virtual CompanyLicense CompanyLicense { get; set; }
      public virtual ICollection<FeeSchedule> FeeSchedule { get; set; }
      public virtual ICollection<FileMaster> FileMaster { get; set; }
      public virtual ICollection<FundDetail> FundDetail { get; set; }
      public virtual ICollection<FundList> FundList { get; set; }
      public virtual ICollection<InvestmentProduct> InvestmentProduct { get; set; }
      public virtual ICollection<PlanFeeSchedule> PlanFeeSchedule { get; set; }
      public virtual ICollection<PlanFile> PlanFile { get; set; }
      public virtual ICollection<PlanGroup> PlanGroup { get; set; }
      public virtual ICollection<PlanMaster> PlanMaster { get; set; }
      public virtual ICollection<Proposal> Proposal { get; set; }
      public virtual RecordKeeper RecordKeeper { get; set; }
      public virtual ICollection<ReportPiece> ReportPiece { get; set; }
      public virtual ICollection<ReportRequest> ReportRequest { get; set; }
      public virtual ICollection<ReportTemplate> ReportTemplate { get; set; }
      public virtual ICollection<Review> Review { get; set; }
      public virtual ICollection<ScoringTool> ScoringTool { get; set; }
      public virtual ICollection<TradingPlatform> TradingPlatform { get; set; }
      public virtual ICollection<User> User { get; set; }
   }
}

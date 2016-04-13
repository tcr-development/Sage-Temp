using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class Proposal {
      public Proposal() {
         ProposalAccess = new HashSet<ProposalAccess>();
         ProposalBalanceMap = new HashSet<ProposalBalanceMap>();
         ProposalInvestment = new HashSet<ProposalInvestment>();
         ProposalPlanContact = new HashSet<ProposalPlanContact>();
         ProposalReport = new HashSet<ProposalReport>();
      }

      public int Id { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public bool Archived { get; set; }
      public string City { get; set; }
      public int CompanyId { get; set; }
      public string CompanyName { get; set; }
      public DateTime CreatedDate { get; set; }
      public int? CurrentFeeScheduleId { get; set; }
      public int? CurrentTradingPlatformId { get; set; }
      public int DataFeedId { get; set; }
      public string EIN { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public int? ParticipantCount { get; set; }
      public string Phone { get; set; }
      public string PlanName { get; set; }
      public int? ProposedFeeScheduleId { get; set; }
      public int? ProposedTradingPlatformId { get; set; }
      public int? ScoreWarehouseId { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }

      public virtual ICollection<ProposalAccess> ProposalAccess { get; set; }
      public virtual ICollection<ProposalBalanceMap> ProposalBalanceMap { get; set; }
      public virtual ICollection<ProposalInvestment> ProposalInvestment { get; set; }
      public virtual ICollection<ProposalPlanContact> ProposalPlanContact { get; set; }
      public virtual ICollection<ProposalReport> ProposalReport { get; set; }
      public virtual Company Company { get; set; }
      public virtual FeeSchedule CurrentFeeSchedule { get; set; }
      public virtual TradingPlatform CurrentTradingPlatform { get; set; }
      public virtual DataFeed DataFeed { get; set; }
      public virtual FeeSchedule ProposedFeeSchedule { get; set; }
      public virtual TradingPlatform ProposedTradingPlatform { get; set; }
      public virtual ScoreWarehouse ScoreWarehouse { get; set; }
   }
}

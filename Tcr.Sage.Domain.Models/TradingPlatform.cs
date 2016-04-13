using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TradingPlatform {
      public TradingPlatform() {
         FundList = new HashSet<FundList>();
         PlanDetail = new HashSet<PlanDetail>();
         Proposal = new HashSet<Proposal>();
         ProposalNavigation = new HashSet<Proposal>();
         ScoringTool = new HashSet<ScoringTool>();
         TradingPlatformAccess = new HashSet<TradingPlatformAccess>();
         TradingPlatformFund = new HashSet<TradingPlatformFund>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }

      public virtual ICollection<FundList> FundList { get; set; }
      public virtual ICollection<PlanDetail> PlanDetail { get; set; }
      public virtual ICollection<Proposal> Proposal { get; set; }
      public virtual ICollection<Proposal> ProposalNavigation { get; set; }
      public virtual ICollection<ScoringTool> ScoringTool { get; set; }
      public virtual ICollection<TradingPlatformAccess> TradingPlatformAccess { get; set; }
      public virtual ICollection<TradingPlatformFund> TradingPlatformFund { get; set; }
      public virtual Company Company { get; set; }
   }
}

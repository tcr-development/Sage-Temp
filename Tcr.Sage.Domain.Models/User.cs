using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class User {
      public User() {
         BenchmarkAccess = new HashSet<BenchmarkAccess>();
         FeeScheduleAccess = new HashSet<FeeScheduleAccess>();
         FundListAccess = new HashSet<FundListAccess>();
         PlanAccess = new HashSet<PlanAccess>();
         PlanGroupAccess = new HashSet<PlanGroupAccess>();
         ProposalAccess = new HashSet<ProposalAccess>();
         ReportTemplateAccess = new HashSet<ReportTemplateAccess>();
         ScoringToolAccess = new HashSet<ScoringToolAccess>();
         TradingPlatformAccess = new HashSet<TradingPlatformAccess>();
      }

      public int UserId { get; set; }
      public byte AcceptTerms { get; set; }
      public string CellPhone { get; set; }
      public int CompanyId { get; set; }
      public string FirstName { get; set; }
      public string HomePhone { get; set; }
      public string LastName { get; set; }
      public byte ModelRebalPct { get; set; }
      public byte? MonitorScore { get; set; }
      public string OtherEmail { get; set; }
      public byte? PassScore { get; set; }
      public byte? WatchScore { get; set; }
      public string WorkEmail { get; set; }
      public string WorkPhone { get; set; }

      public virtual ICollection<BenchmarkAccess> BenchmarkAccess { get; set; }
      public virtual ICollection<FeeScheduleAccess> FeeScheduleAccess { get; set; }
      public virtual ICollection<FundListAccess> FundListAccess { get; set; }
      public virtual ICollection<PlanAccess> PlanAccess { get; set; }
      public virtual ICollection<PlanGroupAccess> PlanGroupAccess { get; set; }
      public virtual ICollection<ProposalAccess> ProposalAccess { get; set; }
      public virtual ICollection<ReportTemplateAccess> ReportTemplateAccess { get; set; }
      public virtual ICollection<ScoringToolAccess> ScoringToolAccess { get; set; }
      public virtual ICollection<TradingPlatformAccess> TradingPlatformAccess { get; set; }
      public virtual Company Company { get; set; }
      public virtual AspNetUsers UserNavigation { get; set; }
   }
}

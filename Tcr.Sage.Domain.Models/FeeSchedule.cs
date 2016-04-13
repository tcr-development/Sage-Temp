using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class FeeSchedule {
      public FeeSchedule() {
         FeeScheduleAccess = new HashSet<FeeScheduleAccess>();
         FeeScheduleServiceProvider = new HashSet<FeeScheduleServiceProvider>();
         PlanFeeSchedule = new HashSet<PlanFeeSchedule>();
         CurrentFeeScheduleProposals = new HashSet<Proposal>();
         ProposedFeeScheduleProposals = new HashSet<Proposal>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }

      public virtual ICollection<FeeScheduleAccess> FeeScheduleAccess { get; set; }
      public virtual ICollection<FeeScheduleServiceProvider> FeeScheduleServiceProvider { get; set; }
      public virtual ICollection<PlanFeeSchedule> PlanFeeSchedule { get; set; }
      public virtual ICollection<Proposal> CurrentFeeScheduleProposals { get; set; }
      public virtual ICollection<Proposal> ProposedFeeScheduleProposals { get; set; }
      public virtual Company Company { get; set; }
   }
}

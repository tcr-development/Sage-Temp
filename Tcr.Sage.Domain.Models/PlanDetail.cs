using System;

namespace Tcr.Sage.Domain.Models {
   public partial class PlanDetail {
      public int PlanMasterId { get; set; }
      public DateTime? NextReviewDate { get; set; }
      public string Notes { get; set; }
      public int? ParticipantCount { get; set; }
      public byte? ReviewFrequencyCd { get; set; }
      public int? TradingPlatformId { get; set; }

      public virtual PlanMaster PlanMaster { get; set; }
      public virtual TradingPlatform TradingPlatform { get; set; }
   }
}

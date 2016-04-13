using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ScoringTool {
      public ScoringTool() {
         ScoringToolAccess = new HashSet<ScoringToolAccess>();
         ScoringToolDetail = new HashSet<ScoringToolDetail>();
      }

      public int Id { get; set; }
      public bool Archived { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public DateTime LastModifyDate { get; set; }
      public bool Locked { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public byte ScoringToolTypeCd { get; set; }
      public int? TradingPlatformId { get; set; }

      public virtual ICollection<ScoringToolAccess> ScoringToolAccess { get; set; }
      public virtual ICollection<ScoringToolDetail> ScoringToolDetail { get; set; }
      public virtual Company Company { get; set; }
      public virtual SageItemType ScoringToolTypeCdNavigation { get; set; }
      public virtual TradingPlatform TradingPlatform { get; set; }
   }
}

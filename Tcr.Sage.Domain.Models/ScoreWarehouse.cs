using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ScoreWarehouse {
      public ScoreWarehouse() {
         Proposal = new HashSet<Proposal>();
         Review = new HashSet<Review>();
         ScoreWarehouseInvestmentScore = new HashSet<ScoreWarehouseInvestmentScore>();
         ScoreWarehouseToolDetail = new HashSet<ScoreWarehouseToolDetail>();
      }

      public int Id { get; set; }
      public DateTime CreatedDateUtc { get; set; }
      public int OwningItemId { get; set; }
      public byte OwningItemTypeCd { get; set; }
      public int ScoringToolId { get; set; }
      public string ScoringToolName { get; set; }
      public byte ScoringToolTypeCd { get; set; }

      public virtual ICollection<Proposal> Proposal { get; set; }
      public virtual ICollection<Review> Review { get; set; }
      public virtual ICollection<ScoreWarehouseInvestmentScore> ScoreWarehouseInvestmentScore { get; set; }
      public virtual ICollection<ScoreWarehouseToolDetail> ScoreWarehouseToolDetail { get; set; }
      public virtual SageItemType OwningItemTypeCdNavigation { get; set; }
      public virtual SageItemType ScoringToolTypeCdNavigation { get; set; }
   }
}

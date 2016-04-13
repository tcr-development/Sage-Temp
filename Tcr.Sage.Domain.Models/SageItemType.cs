using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class SageItemType {
      public SageItemType() {
         ScoreWarehouse = new HashSet<ScoreWarehouse>();
         ScoreWarehouseNavigation = new HashSet<ScoreWarehouse>();
         ScoringTool = new HashSet<ScoringTool>();
      }

      public byte Id { get; set; }
      public string Description { get; set; }

      public virtual ICollection<ScoreWarehouse> ScoreWarehouse { get; set; }
      public virtual ICollection<ScoreWarehouse> ScoreWarehouseNavigation { get; set; }
      public virtual ICollection<ScoringTool> ScoringTool { get; set; }
   }
}

using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestCompareAgainst {
      public TestCompareAgainst() {
         ScoreWarehouseToolDetail = new HashSet<ScoreWarehouseToolDetail>();
         ScoringToolDetail = new HashSet<ScoringToolDetail>();
         TestCompareAgainstListDetail = new HashSet<TestCompareAgainstListDetail>();
      }

      public byte Id { get; set; }
      public string DisplayText { get; set; }

      public virtual ICollection<ScoreWarehouseToolDetail> ScoreWarehouseToolDetail { get; set; }
      public virtual ICollection<ScoringToolDetail> ScoringToolDetail { get; set; }
      public virtual ICollection<TestCompareAgainstListDetail> TestCompareAgainstListDetail { get; set; }
   }
}

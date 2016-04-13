using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestCompareOperator {
      public TestCompareOperator() {
         ScoreWarehouseToolDetail = new HashSet<ScoreWarehouseToolDetail>();
         ScoringToolDetail = new HashSet<ScoringToolDetail>();
         TestCompareOperatorListDetail = new HashSet<TestCompareOperatorListDetail>();
      }

      public byte Id { get; set; }
      public string DisplayText { get; set; }

      public virtual ICollection<ScoreWarehouseToolDetail> ScoreWarehouseToolDetail { get; set; }
      public virtual ICollection<ScoringToolDetail> ScoringToolDetail { get; set; }
      public virtual ICollection<TestCompareOperatorListDetail> TestCompareOperatorListDetail { get; set; }
   }
}

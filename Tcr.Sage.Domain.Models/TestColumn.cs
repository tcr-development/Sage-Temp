using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestColumn {
      public TestColumn() {
         ScoreWarehouseToolDetail = new HashSet<ScoreWarehouseToolDetail>();
         ScoringToolDetail = new HashSet<ScoringToolDetail>();
      }

      public int Id { get; set; }
      public bool AllowForFilter { get; set; }
      public bool AllowForPassFail { get; set; }
      public bool AllowForPointBased { get; set; }
      public string ColumnName { get; set; }
      public string DisplayText { get; set; }
      public string FormatMask { get; set; }
      public byte OrderNum { get; set; }
      public byte? TestCompareAgainstListId { get; set; }
      public byte TestCompareOperatorListId { get; set; }
      public byte TestDataTypeId { get; set; }
      public byte TestSectionId { get; set; }

      public virtual ICollection<ScoreWarehouseToolDetail> ScoreWarehouseToolDetail { get; set; }
      public virtual ICollection<ScoringToolDetail> ScoringToolDetail { get; set; }
      public virtual TestCompareAgainstList TestCompareAgainstList { get; set; }
      public virtual TestCompareOperatorList TestCompareOperatorList { get; set; }
      public virtual TestDataType TestDataType { get; set; }
      public virtual TestSection TestSection { get; set; }
   }
}

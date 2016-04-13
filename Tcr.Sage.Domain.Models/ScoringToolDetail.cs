namespace Tcr.Sage.Domain.Models {
   public partial class ScoringToolDetail {
      public int Id { get; set; }
      public string LowerValue { get; set; }
      public int ScoringToolId { get; set; }
      public int TestColumnId { get; set; }
      public byte TestCompareAgainstCd { get; set; }
      public byte TestCompareOperatorCd { get; set; }
      public string UpperValue { get; set; }
      public decimal? Weighting { get; set; }

      public virtual ScoringTool ScoringTool { get; set; }
      public virtual TestColumn TestColumn { get; set; }
      public virtual TestCompareAgainst TestCompareAgainstCdNavigation { get; set; }
      public virtual TestCompareOperator TestCompareOperatorCdNavigation { get; set; }
   }
}

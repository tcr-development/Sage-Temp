namespace Tcr.Sage.Domain.Models {
   public partial class ScoreWarehouseToolDetail {
      public int Id { get; set; }
      public byte CompareAgainstCd { get; set; }
      public byte CompareOperatorCd { get; set; }
      public string LowerValue { get; set; }
      public int ScoreWarehouseId { get; set; }
      public int TestColumnId { get; set; }
      public string UpperValue { get; set; }
      public decimal? Weighting { get; set; }

      public virtual TestCompareAgainst CompareAgainstCdNavigation { get; set; }
      public virtual TestCompareOperator CompareOperatorCdNavigation { get; set; }
      public virtual ScoreWarehouse ScoreWarehouse { get; set; }
      public virtual TestColumn TestColumn { get; set; }
   }
}

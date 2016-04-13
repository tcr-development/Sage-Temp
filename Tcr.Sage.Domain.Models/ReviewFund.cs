namespace Tcr.Sage.Domain.Models {
   public partial class ReviewFund {
      public int Id { get; set; }
      public decimal? Balance { get; set; }
      public int FundDetailId { get; set; }
      public byte FundTypeCd { get; set; }
      public int ReviewPlanId { get; set; }

      public virtual FundDetail FundDetail { get; set; }
      public virtual ReviewPlan ReviewPlan { get; set; }
   }
}

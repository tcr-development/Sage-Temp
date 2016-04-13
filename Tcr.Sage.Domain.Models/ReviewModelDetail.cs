namespace Tcr.Sage.Domain.Models {
   public partial class ReviewModelDetail {
      public int Id { get; set; }
      public decimal? Balance { get; set; }
      public int FundDetailId { get; set; }
      public int ReviewModelId { get; set; }

      public virtual FundDetail FundDetail { get; set; }
      public virtual ReviewModel ReviewModel { get; set; }
   }
}

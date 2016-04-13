namespace Tcr.Sage.Domain.Models {
   public partial class ModelFreezerDetail {
      public int Id { get; set; }
      public decimal AlloPct { get; set; }
      public int FundDetailId { get; set; }
      public int ModelFreezerId { get; set; }

      public virtual FundDetail FundDetail { get; set; }
      public virtual ModelFreezer ModelFreezer { get; set; }
   }
}

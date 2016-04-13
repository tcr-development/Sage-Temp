namespace Tcr.Sage.Domain.Models {
   public partial class FundListFund {
      public int ListId { get; set; }
      public int FundId { get; set; }

      public virtual FundDetail Fund { get; set; }
      public virtual FundList List { get; set; }
   }
}

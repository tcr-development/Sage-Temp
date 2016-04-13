namespace Tcr.Sage.Domain.Models {
   public partial class FeeStepRate {
      public int Id { get; set; }
      public decimal Amount { get; set; }
      public decimal FromValue { get; set; }
      public byte OrderNum { get; set; }
      public int ServiceProviderFeeId { get; set; }
      public decimal? ToValue { get; set; }

      public virtual ServiceProviderFee ServiceProviderFee { get; set; }
   }
}

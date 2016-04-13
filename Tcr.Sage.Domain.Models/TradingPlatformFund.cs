namespace Tcr.Sage.Domain.Models {
   public partial class TradingPlatformFund {
      public int Id { get; set; }
      public string Cusip { get; set; }
      public string Notes { get; set; }
      public decimal? RevShareBps { get; set; }
      public decimal? SubTaBps { get; set; }
      public decimal? SubTaDollar { get; set; }
      public int TradingPlatformId { get; set; }

      public virtual TradingPlatform TradingPlatform { get; set; }
   }
}

namespace Tcr.Sage.Domain.Models {
   public partial class TradingPlatformAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int TradingPlatformId { get; set; }
      public int UserId { get; set; }

      public virtual TradingPlatform TradingPlatform { get; set; }
      public virtual User User { get; set; }
   }
}

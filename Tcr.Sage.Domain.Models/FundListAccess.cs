namespace Tcr.Sage.Domain.Models {
   public partial class FundListAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int FundListId { get; set; }
      public int UserId { get; set; }

      public virtual FundList FundList { get; set; }
      public virtual User User { get; set; }
   }
}

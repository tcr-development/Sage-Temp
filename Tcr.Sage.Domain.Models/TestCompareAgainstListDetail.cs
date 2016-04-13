namespace Tcr.Sage.Domain.Models {
   public partial class TestCompareAgainstListDetail {
      public byte Id { get; set; }
      public bool AllowForPassFail { get; set; }
      public bool AllowForPointBased { get; set; }
      public byte? PassFailOrderNum { get; set; }
      public byte? PointBasedOrderNum { get; set; }
      public byte TestCompareAgainstId { get; set; }
      public byte TestCompareAgainstListId { get; set; }

      public virtual TestCompareAgainst TestCompareAgainst { get; set; }
      public virtual TestCompareAgainstList TestCompareAgainstList { get; set; }
   }
}

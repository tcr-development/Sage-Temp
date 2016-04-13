namespace Tcr.Sage.Domain.Models {
   public partial class TestCompareOperatorListDetail {
      public byte Id { get; set; }
      public byte OrderNum { get; set; }
      public byte TestCompareOperatorId { get; set; }
      public byte TestCompareOperatorListId { get; set; }

      public virtual TestCompareOperator TestCompareOperator { get; set; }
      public virtual TestCompareOperatorList TestCompareOperatorList { get; set; }
   }
}

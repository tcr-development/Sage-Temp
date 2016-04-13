namespace Tcr.Sage.Domain.Models {
   public partial class PlanGroupAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int PlanGroupId { get; set; }
      public int UserId { get; set; }

      public virtual PlanGroup PlanGroup { get; set; }
      public virtual User User { get; set; }
   }
}

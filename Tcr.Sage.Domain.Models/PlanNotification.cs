namespace Tcr.Sage.Domain.Models {
   public partial class PlanNotification {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int PlanMasterId { get; set; }
      public int UserId { get; set; }

      public virtual PlanMaster PlanMaster { get; set; }
      public virtual AspNetUsers User { get; set; }
   }
}

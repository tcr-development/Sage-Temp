namespace Tcr.Sage.Domain.Models {
   public partial class PlanAccess {
      public int UserId { get; set; }
      public int PlanMasterId { get; set; }

      public virtual PlanMaster PlanMaster { get; set; }
      public virtual User User { get; set; }
   }
}

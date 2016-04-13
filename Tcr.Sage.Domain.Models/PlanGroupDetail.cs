namespace Tcr.Sage.Domain.Models {
   public partial class PlanGroupDetail {
      public int Id { get; set; }
      public int PlanGroupId { get; set; }
      public int PlanMasterId { get; set; }

      public virtual PlanGroup PlanGroup { get; set; }
      public virtual PlanMaster PlanMaster { get; set; }
   }
}

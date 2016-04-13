namespace Tcr.Sage.Domain.Models {
   public partial class PlanFeeSchedule {
      public int Id { get; set; }
      public int CompanyId { get; set; }
      public int FeeScheduleId { get; set; }
      public int PlanMasterId { get; set; }

      public virtual Company Company { get; set; }
      public virtual FeeSchedule FeeSchedule { get; set; }
      public virtual PlanMaster PlanMaster { get; set; }
   }
}

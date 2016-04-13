namespace Tcr.Sage.Domain.Models {
   public partial class PlanReport {
      public int Id { get; set; }
      public int FileMasterId { get; set; }
      public int PlanMasterId { get; set; }
      public byte ReportTypeCd { get; set; }

      public virtual FileMaster FileMaster { get; set; }
      public virtual PlanMaster PlanMaster { get; set; }
   }
}

namespace Tcr.Sage.Domain.Models {
   public partial class PlanFile {
      public int Id { get; set; }
      public int CompanyId { get; set; }
      public int FileMasterId { get; set; }
      public bool IncludeInPlans { get; set; }
      public bool IncludeInReviews { get; set; }
      public byte OrderNum { get; set; }
      public int PlanMasterId { get; set; }

      public virtual Company Company { get; set; }
      public virtual FileMaster FileMaster { get; set; }
      public virtual PlanMaster PlanMaster { get; set; }
   }
}

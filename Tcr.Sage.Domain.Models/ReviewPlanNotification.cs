namespace Tcr.Sage.Domain.Models {
   public partial class ReviewPlanNotification {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int ReviewPlanId { get; set; }
      public int UserId { get; set; }

      public virtual ReviewPlan ReviewPlan { get; set; }
      public virtual AspNetUsers User { get; set; }
   }
}

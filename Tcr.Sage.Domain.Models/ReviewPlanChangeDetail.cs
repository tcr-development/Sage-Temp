namespace Tcr.Sage.Domain.Models {
   public partial class ReviewPlanChangeDetail {
      public int Id { get; set; }
      public string Cusip { get; set; }
      public decimal NewAlloPct { get; set; }
      public int ReviewPlanChangeId { get; set; }

      public virtual ReviewPlanChange ReviewPlanChange { get; set; }
   }
}

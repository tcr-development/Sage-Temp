using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ReviewModel {
      public ReviewModel() {
         ReviewModelDetail = new HashSet<ReviewModelDetail>();
      }

      public int Id { get; set; }
      public decimal? Balance { get; set; }
      public int ModelFreezerId { get; set; }
      public int ReviewPlanId { get; set; }

      public virtual ICollection<ReviewModelDetail> ReviewModelDetail { get; set; }
      public virtual ModelFreezer ModelFreezer { get; set; }
      public virtual ReviewPlan ReviewPlan { get; set; }
   }
}

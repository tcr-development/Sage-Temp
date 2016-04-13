using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ReviewPlanChange {
      public ReviewPlanChange() {
         ReviewPlanChangeDetail = new HashSet<ReviewPlanChangeDetail>();
      }

      public int Id { get; set; }
      public byte ChangeStatusCd { get; set; }
      public byte ChangeTypeCd { get; set; }
      public bool IncludeRebalance { get; set; }
      public string InvestmentId1 { get; set; }
      public string InvestmentId2 { get; set; }
      public string Note { get; set; }
      public int ReviewPlanId { get; set; }

      public virtual ICollection<ReviewPlanChangeDetail> ReviewPlanChangeDetail { get; set; }
      public virtual ReviewPlan ReviewPlan { get; set; }
   }
}

using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class Review {
      public Review() {
         ReviewPlan = new HashSet<ReviewPlan>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public DateTime? FollowUpDate { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public byte ReviewStatusCd { get; set; }
      public int? ScoreWarehouseId { get; set; }

      public virtual ICollection<ReviewPlan> ReviewPlan { get; set; }
      public virtual Company Company { get; set; }
      public virtual ScoreWarehouse ScoreWarehouse { get; set; }
   }
}

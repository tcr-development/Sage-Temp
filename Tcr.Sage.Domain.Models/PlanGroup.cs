using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class PlanGroup {
      public PlanGroup() {
         PlanGroupAccess = new HashSet<PlanGroupAccess>();
         PlanGroupDetail = new HashSet<PlanGroupDetail>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }

      public virtual ICollection<PlanGroupAccess> PlanGroupAccess { get; set; }
      public virtual ICollection<PlanGroupDetail> PlanGroupDetail { get; set; }
      public virtual Company Company { get; set; }
   }
}

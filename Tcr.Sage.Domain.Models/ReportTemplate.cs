using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ReportTemplate {
      public ReportTemplate() {
         ReportTemplateAccess = new HashSet<ReportTemplateAccess>();
         ReportTemplateDetail = new HashSet<ReportTemplateDetail>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }
      public byte ReportTypeCd { get; set; }

      public virtual ICollection<ReportTemplateAccess> ReportTemplateAccess { get; set; }
      public virtual ICollection<ReportTemplateDetail> ReportTemplateDetail { get; set; }
      public virtual Company Company { get; set; }
   }
}

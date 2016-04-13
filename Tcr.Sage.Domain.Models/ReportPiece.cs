using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ReportPiece {
      public ReportPiece() {
         ReportTemplateDetail = new HashSet<ReportTemplateDetail>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public int FileMasterId { get; set; }
      public byte ReportTypeCd { get; set; }

      public virtual ICollection<ReportTemplateDetail> ReportTemplateDetail { get; set; }
      public virtual Company Company { get; set; }
      public virtual FileMaster FileMaster { get; set; }
   }
}

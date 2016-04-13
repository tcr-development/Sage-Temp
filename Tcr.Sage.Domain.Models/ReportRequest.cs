using System;

namespace Tcr.Sage.Domain.Models {
   public partial class ReportRequest {
      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime? CompletedDate { get; set; }
      public int? FileMasterId { get; set; }
      public string FundDetailIds { get; set; }
      public int? ItemId { get; set; }
      public string OutputFileName { get; set; }
      public int? PlanMasterId { get; set; }
      public int ReportTemplateId { get; set; }
      public byte ReportTypeCd { get; set; }
      public DateTime RequestDate { get; set; }
      public byte StatusCd { get; set; }
      public string StatusMessage { get; set; }

      public virtual Company Company { get; set; }
      public virtual PlanMaster PlanMaster { get; set; }
   }
}

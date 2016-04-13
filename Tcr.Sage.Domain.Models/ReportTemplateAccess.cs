namespace Tcr.Sage.Domain.Models {
   public partial class ReportTemplateAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int ReportTemplateId { get; set; }
      public int UserId { get; set; }

      public virtual ReportTemplate ReportTemplate { get; set; }
      public virtual User User { get; set; }
   }
}

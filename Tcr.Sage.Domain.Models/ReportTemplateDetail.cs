namespace Tcr.Sage.Domain.Models {
   public partial class ReportTemplateDetail {
      public int Id { get; set; }
      public bool NumberPages { get; set; }
      public byte OrderNum { get; set; }
      public int ReportPieceId { get; set; }
      public int ReportTemplateId { get; set; }

      public virtual ReportPiece ReportPiece { get; set; }
      public virtual ReportTemplate ReportTemplate { get; set; }
   }
}

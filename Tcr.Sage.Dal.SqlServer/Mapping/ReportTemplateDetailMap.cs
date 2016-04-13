using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReportTemplateDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReportTemplateDetail>(entity => {
            entity.HasIndex(e => e.ReportTemplateId).HasName("idx_ReportTemplateDetail");

            entity.HasOne(d => d.ReportPiece).WithMany(p => p.ReportTemplateDetail).HasForeignKey(d => d.ReportPieceId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ReportTemplate).WithMany(p => p.ReportTemplateDetail).HasForeignKey(d => d.ReportTemplateId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
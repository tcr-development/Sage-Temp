using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReportTemplateAccessMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReportTemplateAccess>(entity => {
            entity.HasIndex(e => e.ReportTemplateId).HasName("idx_ReportTemplateAccess");

            entity.HasOne(d => d.ReportTemplate).WithMany(p => p.ReportTemplateAccess).HasForeignKey(d => d.ReportTemplateId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.ReportTemplateAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
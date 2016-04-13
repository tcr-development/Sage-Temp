using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReportPieceMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReportPiece>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("idx_ReportPiece");

            entity.HasOne(d => d.Company).WithMany(p => p.ReportPiece).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.FileMaster).WithMany(p => p.ReportPiece).HasForeignKey(d => d.FileMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
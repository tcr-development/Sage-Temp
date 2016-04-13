using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class PlanReportMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanReport>(entity => {
            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_PlanReport_PlanMasterId");

            entity.HasOne(d => d.FileMaster).WithMany(p => p.PlanReport).HasForeignKey(d => d.FileMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanReport).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
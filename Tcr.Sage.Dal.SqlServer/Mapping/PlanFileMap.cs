using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanFileMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanFile>(entity => {
            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_PlanFile_PlanMasterId");

            entity.HasOne(d => d.Company).WithMany(p => p.PlanFile).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.FileMaster).WithMany(p => p.PlanFile).HasForeignKey(d => d.FileMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanFile).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanGroupDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanGroupDetail>(entity => {
            entity.HasIndex(e => e.PlanGroupId).HasName("idx_PlanGroupDetail");

            entity.HasOne(d => d.PlanGroup).WithMany(p => p.PlanGroupDetail).HasForeignKey(d => d.PlanGroupId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanGroupDetail).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
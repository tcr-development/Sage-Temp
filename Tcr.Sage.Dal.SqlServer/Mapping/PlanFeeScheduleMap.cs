using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanFeeScheduleMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanFeeSchedule>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_PlanFeeSchedule_CompanyId");

            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_PlanFeeSchedule_PlanId");

            entity.HasIndex(e => new { e.CompanyId, e.PlanMasterId }).HasName("UQ_PlanFeeSchedule_Company").IsUnique();

            entity.HasOne(d => d.Company).WithMany(p => p.PlanFeeSchedule).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.FeeSchedule).WithMany(p => p.PlanFeeSchedule).HasForeignKey(d => d.FeeScheduleId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanFeeSchedule).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
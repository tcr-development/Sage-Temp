using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FeeScheduleServiceProviderMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FeeScheduleServiceProvider>(entity => {
            entity.HasIndex(e => e.FeeScheduleId).HasName("Idx_FeeScheduleServiceProvider_FeeScheduleId");

            entity.HasOne(d => d.FeeSchedule).WithMany(p => p.FeeScheduleServiceProvider).HasForeignKey(d => d.FeeScheduleId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ServiceProvider).WithMany(p => p.FeeScheduleServiceProvider).HasForeignKey(d => d.ServiceProviderId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
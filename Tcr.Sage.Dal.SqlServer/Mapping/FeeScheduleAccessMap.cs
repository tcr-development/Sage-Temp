using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FeeScheduleAccessMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FeeScheduleAccess>(entity => {
            entity.HasIndex(e => e.UserId).HasName("Idx_FeeScheduleAccess_UserId");

            entity.HasOne(d => d.FeeSchedule).WithMany(p => p.FeeScheduleAccess).HasForeignKey(d => d.FeeScheduleId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.FeeScheduleAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
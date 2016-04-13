using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class PlanNotificationMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanNotification>(entity => {
            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_PlanNotification_PlanMasterId");

            entity.HasIndex(e => e.UserId).HasName("Idx_PlanNotification_UserId");

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanNotification).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.PlanNotification).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
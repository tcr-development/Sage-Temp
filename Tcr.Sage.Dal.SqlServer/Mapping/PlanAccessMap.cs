using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanAccessMap {
      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanAccess>(entity => {
            entity.HasKey(e => new { e.UserId, e.PlanMasterId });

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanAccess).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.PlanAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
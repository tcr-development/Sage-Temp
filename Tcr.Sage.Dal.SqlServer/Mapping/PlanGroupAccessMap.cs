using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanGroupAccessMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanGroupAccess>(entity => {
            entity.HasIndex(e => e.PlanGroupId).HasName("idx_PlanGroupAccess");

            entity.HasOne(d => d.PlanGroup).WithMany(p => p.PlanGroupAccess).HasForeignKey(d => d.PlanGroupId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.PlanGroupAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
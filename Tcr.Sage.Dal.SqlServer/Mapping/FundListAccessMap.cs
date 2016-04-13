using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FundListAccessMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FundListAccess>(entity => {
            entity.HasIndex(e => e.UserId).HasName("Idx_FundListAccess_UserId");

            entity.HasOne(d => d.FundList).WithMany(p => p.FundListAccess).HasForeignKey(d => d.FundListId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.FundListAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
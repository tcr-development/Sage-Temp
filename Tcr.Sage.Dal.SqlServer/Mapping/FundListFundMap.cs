using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FundListFundMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FundListFund>(entity => {
            entity.HasKey(e => new { e.ListId, e.FundId });

            entity.HasOne(d => d.Fund).WithMany(p => p.FundListFund).HasForeignKey(d => d.FundId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.List).WithMany(p => p.FundListFund).HasForeignKey(d => d.ListId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
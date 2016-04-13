using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestCompareAgainstListDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestCompareAgainstListDetail>(entity => {
            entity.HasOne(d => d.TestCompareAgainst).WithMany(p => p.TestCompareAgainstListDetail).HasForeignKey(d => d.TestCompareAgainstId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestCompareAgainstList).WithMany(p => p.TestCompareAgainstListDetail).HasForeignKey(d => d.TestCompareAgainstListId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
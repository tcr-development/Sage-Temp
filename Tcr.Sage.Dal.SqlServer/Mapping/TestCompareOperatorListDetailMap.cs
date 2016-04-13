using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestCompareOperatorListDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestCompareOperatorListDetail>(entity => {
            entity.HasOne(d => d.TestCompareOperator).WithMany(p => p.TestCompareOperatorListDetail).HasForeignKey(d => d.TestCompareOperatorId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestCompareOperatorList).WithMany(p => p.TestCompareOperatorListDetail).HasForeignKey(d => d.TestCompareOperatorListId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
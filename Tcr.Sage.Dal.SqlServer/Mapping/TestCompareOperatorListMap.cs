using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestCompareOperatorListMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestCompareOperatorList>(entity => {
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");
         });
      }
   }
}
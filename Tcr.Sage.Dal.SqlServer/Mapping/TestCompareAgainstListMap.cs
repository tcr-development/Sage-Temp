using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestCompareAgainstListMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestCompareAgainstList>(entity => {
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar");
         });
      }
   }
}
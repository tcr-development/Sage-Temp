using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestCompareAgainstMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestCompareAgainst>(entity => {
            entity.Property(e => e.DisplayText)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");
         });
      }
   }
}
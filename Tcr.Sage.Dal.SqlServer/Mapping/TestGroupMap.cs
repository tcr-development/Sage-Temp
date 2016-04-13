using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestGroupMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestGroup>(entity => {
            entity.Property(e => e.DisplayText)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");
         });
      }
   }
}
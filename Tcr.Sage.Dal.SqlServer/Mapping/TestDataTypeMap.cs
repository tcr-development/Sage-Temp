using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestDataTypeMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestDataType>(entity => {
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar");
         });
      }
   }
}
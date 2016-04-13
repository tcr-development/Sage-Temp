using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class SageItemTypeMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<SageItemType>(entity => {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnType("varchar");
         });
      }
   }
}
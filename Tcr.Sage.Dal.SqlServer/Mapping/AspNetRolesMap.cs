using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class AspNetRolesMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<AspNetRoles>(entity => {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256);
         });
      }
   }
}
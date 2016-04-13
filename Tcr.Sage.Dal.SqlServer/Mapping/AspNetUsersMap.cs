using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class AspNetUsersMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<AspNetUsers>(entity => {
            entity.Property(e => e.Email).HasMaxLength(256);

            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(256);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class AspNetUserLoginsMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<AspNetUserLogins>(entity => {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);

            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
         });
      }
   }
}
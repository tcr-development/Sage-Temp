using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class AspNetUserClaimsMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<AspNetUserClaims>(entity => {
            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
         });
      }
   }
}
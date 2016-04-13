using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class AspNetUserRolesMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<AspNetUserRoles>(entity => {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetUserRoles).HasForeignKey(d => d.RoleId);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserRoles).HasForeignKey(d => d.UserId);
         });
      }
   }
}
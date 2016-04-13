using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class UserMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<User>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_User_CompanyId");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.Property(e => e.CellPhone)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.HomePhone)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.ModelRebalPct).HasDefaultValue(10);

            entity.Property(e => e.OtherEmail)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.WorkEmail)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.User).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.UserNavigation).WithOne(p => p.User).HasForeignKey<User>(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
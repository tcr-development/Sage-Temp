using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class CompanyMap {
      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<Company>(entity => {

            // Primary Key
            entity.HasKey(t => t.Id);

            // Properties
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.CreatedDateUtc)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.IsDisabled).HasDefaultValue(false);

            entity.Property(e => e.IsTestCompany).HasDefaultValue(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.PrimaryContact)
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnType("varchar");

            entity.Property(e => e.Zip)
                .HasMaxLength(30)
                .HasColumnType("varchar");
         });
      }
   }
}
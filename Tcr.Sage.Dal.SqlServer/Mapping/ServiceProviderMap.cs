using Microsoft.Data.Entity;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ServiceProviderMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ServiceProvider>(entity => {
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.EmployerIdNumber)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnType("varchar");

            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnType("varchar");
         });
      }
   }
}
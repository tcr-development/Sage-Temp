using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ServiceProviderFeeMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ServiceProviderFee>(entity => {
            entity.HasIndex(e => e.ServiceProviderId).HasName("Idx_ServiceProviderFee_ServiceProviderId");

            entity.Property(e => e.Amount).HasColumnType("decimal");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.SelectedInvestments)
                .HasMaxLength(1200)
                .HasColumnType("varchar");

            entity.HasOne(d => d.PaidByServiceProvider).WithMany(p => p.ServiceProviderFee).HasForeignKey(d => d.PaidByServiceProviderId);

            entity.HasOne(d => d.ServiceProvider).WithMany(p => p.ServiceProviderFeeNavigation).HasForeignKey(d => d.ServiceProviderId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
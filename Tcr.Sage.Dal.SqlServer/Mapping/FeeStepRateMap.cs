using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FeeStepRateMap {
      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<FeeStepRate>(entity => {
            entity.HasIndex(e => e.ServiceProviderFeeId).HasName("Idx_FeeStepRate_ServiceProviderFeeId");

            entity.Property(e => e.Amount).HasColumnType("decimal");

            entity.Property(e => e.FromValue).HasColumnType("decimal");

            entity.Property(e => e.ToValue).HasColumnType("decimal");

            entity.HasOne(d => d.ServiceProviderFee).WithMany(p => p.FeeStepRate).HasForeignKey(d => d.ServiceProviderFeeId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
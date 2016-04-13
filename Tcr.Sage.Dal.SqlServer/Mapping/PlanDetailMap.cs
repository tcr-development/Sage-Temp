using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanDetail>(entity => {
            entity.HasKey(e => e.PlanMasterId);

            entity.Property(e => e.PlanMasterId).ValueGeneratedNever();

            entity.Property(e => e.NextReviewDate).HasColumnType("date");

            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnType("varchar");

            entity.HasOne(d => d.PlanMaster).WithOne(p => p.PlanDetail).HasForeignKey<PlanDetail>(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TradingPlatform).WithMany(p => p.PlanDetail).HasForeignKey(d => d.TradingPlatformId);
         });
      }
   }
}
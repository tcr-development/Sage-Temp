using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewPlanChangeMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewPlanChange>(entity => {
            entity.HasIndex(e => e.ReviewPlanId).HasName("Idx_ReviewPlanChange_ReviewPlanId");

            entity.Property(e => e.IncludeRebalance).HasDefaultValue(false);

            entity.Property(e => e.InvestmentId1)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.InvestmentId2)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.Note)
                .HasMaxLength(2000)
                .HasColumnType("varchar");

            entity.HasOne(d => d.ReviewPlan).WithMany(p => p.ReviewPlanChange).HasForeignKey(d => d.ReviewPlanId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
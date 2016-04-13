using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewPlanChangeDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewPlanChangeDetail>(entity => {
            entity.HasIndex(e => e.ReviewPlanChangeId).HasName("Idx_ReviewPlanChangeDetail_ReviewPlanChangeId");

            entity.Property(e => e.Cusip)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.NewAlloPct).HasColumnType("decimal");

            entity.HasOne(d => d.ReviewPlanChange).WithMany(p => p.ReviewPlanChangeDetail).HasForeignKey(d => d.ReviewPlanChangeId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
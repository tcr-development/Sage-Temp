using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewFundMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewFund>(entity => {
            entity.HasIndex(e => e.FundDetailId).HasName("Idx_ReviewFund_FundDetailId");

            entity.HasIndex(e => e.ReviewPlanId).HasName("Idx_ReviewFund_ReviewPlanId");

            entity.Property(e => e.Balance).HasColumnType("decimal");

            entity.HasOne(d => d.FundDetail).WithMany(p => p.ReviewFund).HasForeignKey(d => d.FundDetailId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ReviewPlan).WithMany(p => p.ReviewFund).HasForeignKey(d => d.ReviewPlanId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
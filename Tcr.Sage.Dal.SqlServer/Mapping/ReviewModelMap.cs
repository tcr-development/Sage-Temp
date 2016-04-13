using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewModelMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewModel>(entity => {
            entity.HasIndex(e => e.ModelFreezerId).HasName("Idx_ReviewModel_ModelFreezerId");

            entity.HasIndex(e => e.ReviewPlanId).HasName("Idx_ReviewModel_ReviewPlanId");

            entity.Property(e => e.Balance).HasColumnType("decimal");

            entity.HasOne(d => d.ModelFreezer).WithMany(p => p.ReviewModel).HasForeignKey(d => d.ModelFreezerId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ReviewPlan).WithMany(p => p.ReviewModel).HasForeignKey(d => d.ReviewPlanId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
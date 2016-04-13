using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewPlanNotificationMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewPlanNotification>(entity => {
            entity.HasIndex(e => e.ReviewPlanId).HasName("Idx_ReviewPlanNotification_ReviewPlanId");

            entity.HasIndex(e => e.UserId).HasName("Idx_ReviewPlanNotification_UserId");

            entity.HasOne(d => d.ReviewPlan).WithMany(p => p.ReviewPlanNotification).HasForeignKey(d => d.ReviewPlanId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.ReviewPlanNotification).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
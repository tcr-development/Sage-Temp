using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewModelDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReviewModelDetail>(entity => {
            entity.HasIndex(e => e.FundDetailId).HasName("Idx_ReviewModelDetail_FundDetailId");

            entity.HasIndex(e => e.ReviewModelId).HasName("Idx_ReviewModelDetail_ReviewModelId");

            entity.Property(e => e.Balance).HasColumnType("decimal");

            entity.HasOne(d => d.FundDetail).WithMany(p => p.ReviewModelDetail).HasForeignKey(d => d.FundDetailId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ReviewModel).WithMany(p => p.ReviewModelDetail).HasForeignKey(d => d.ReviewModelId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReviewMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<Review>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_Review_CompanyId");

            entity.HasIndex(e => e.ScoreWarehouseId).HasName("Idx_Review_ScoreWarehouseId");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.FollowUpDate).HasColumnType("date");

            entity.Property(e => e.LastModifyDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.Review).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ScoreWarehouse).WithMany(p => p.Review).HasForeignKey(d => d.ScoreWarehouseId);
         });
      }
   }
}
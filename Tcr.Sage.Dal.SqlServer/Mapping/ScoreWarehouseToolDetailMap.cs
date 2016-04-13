using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ScoreWarehouseToolDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ScoreWarehouseToolDetail>(entity => {
            entity.HasIndex(e => e.ScoreWarehouseId).HasName("Idx_ScoreWarehouseToolDetail_ScoreWarehouseId");

            entity.Property(e => e.LowerValue)
                .HasMaxLength(1000)
                .HasColumnType("varchar");

            entity.Property(e => e.UpperValue)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.Weighting).HasColumnType("decimal");

            entity.HasOne(d => d.CompareAgainstCdNavigation).WithMany(p => p.ScoreWarehouseToolDetail).HasForeignKey(d => d.CompareAgainstCd).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.CompareOperatorCdNavigation).WithMany(p => p.ScoreWarehouseToolDetail).HasForeignKey(d => d.CompareOperatorCd).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ScoreWarehouse).WithMany(p => p.ScoreWarehouseToolDetail).HasForeignKey(d => d.ScoreWarehouseId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestColumn).WithMany(p => p.ScoreWarehouseToolDetail).HasForeignKey(d => d.TestColumnId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
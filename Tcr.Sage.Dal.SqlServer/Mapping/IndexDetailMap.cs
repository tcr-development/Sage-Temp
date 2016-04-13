using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class IndexDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<IndexDetail>(entity => {

            entity.Property(e => e.IndexId)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.M0ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M120StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M12ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M12SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M12StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M36ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M36SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M36StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M3ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M60StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.HasOne(d => d.DataFeed).WithMany(p => p.IndexDetail).HasForeignKey(d => d.DataFeedId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
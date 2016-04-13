using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class CategoryDetailMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<CategoryDetail>(entity => {

            // Primary Key
            entity.HasKey(t => t.Id);

            // Properties
            entity.Property(e => e.CategoryId)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.ExpenseRatio).HasColumnType("decimal");

            entity.Property(e => e.M0ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M120BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M120ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M120SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M120StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M12AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M12BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M12ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M12RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M36RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M36StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M60AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M60BattingAverage).HasColumnType("decimal");

            entity.Property(e => e.M60BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M60CaptureRatioDown).HasColumnType("decimal");

            entity.Property(e => e.M60CaptureRatioUp).HasColumnType("decimal");

            entity.Property(e => e.M60ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M60SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M60StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.ManagerTenure).HasColumnType("decimal");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.NetAssets).HasColumnType("decimal");

            entity.Property(e => e.NetExpenseRatio).HasColumnType("decimal");

            entity.Property(e => e.TurnoverRatio).HasColumnType("decimal");

            // Relationships
            entity.HasOne(d => d.DataFeed).WithMany(p => p.CategoryDetail).HasForeignKey(d => d.DataFeedId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
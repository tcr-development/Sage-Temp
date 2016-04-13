using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ScoreWarehouseInvestmentScoreMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ScoreWarehouseInvestmentScore>(entity => {
            entity.HasIndex(e => e.ScoreWarehouseId).HasName("Idx_ScoreWarehouseInvestmentScore_ScoreWarehouseId");

            entity.Property(e => e.AssetAllo)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.AssetAlloBlend)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.InceptionDate)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M0ReturnRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M0ReturnValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120AlphaPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120AlphaRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120BetaPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120BetaRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120PerfRatingDesc)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120RatingValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120ReturnRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120ReturnValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120RiskRatingDesc)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120RSquaredPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120RSquaredRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120SharpeRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120SharpeRatio)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M120StandardDeviation)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M12ReturnRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M12ReturnValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M12SharpeRatio)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M12StandardDeviation)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M255RatingValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36AlphaPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36AlphaRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36BetaPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36BetaRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36PerfRatingDesc)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36RatingValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36ReturnRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36ReturnValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36RiskRatingDesc)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36RSquaredPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36RSquaredRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36SharpeRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36SharpeRatio)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M36StandardDeviation)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60AlphaPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60AlphaRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60BattingAverage)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60BetaPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60BetaRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60CaptureRatioDown)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60CaptureRatioUp)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60PerfRatingDesc)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60RatingValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60ReturnRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60ReturnValue)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60RiskRatingDesc)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60RSquaredPrimary)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60RSquaredRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60SharpeRank)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60SharpeRatio)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.M60StandardDeviation)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.ManagerTenure)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.Momentum)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.NetAssets)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.NetExpenseRatio)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.NumberOfHolding)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.Top10HoldingWeighting)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.Property(e => e.TotalPoints).HasColumnType("decimal");

            entity.Property(e => e.TurnoverRatio)
                .HasMaxLength(15)
                .HasColumnType("varchar");

            entity.HasOne(d => d.FundDetail).WithMany(p => p.ScoreWarehouseInvestmentScore).HasForeignKey(d => d.FundDetailId);

            entity.HasOne(d => d.ModelFreezer).WithMany(p => p.ScoreWarehouseInvestmentScore).HasForeignKey(d => d.ModelFreezerId);

            entity.HasOne(d => d.ScoreWarehouse).WithMany(p => p.ScoreWarehouseInvestmentScore).HasForeignKey(d => d.ScoreWarehouseId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
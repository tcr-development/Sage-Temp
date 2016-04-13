using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FundDetailMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FundDetail>(entity => {
            entity.Property(e => e.Actual12b1).HasColumnType("decimal");

            entity.Property(e => e.AnnualReportDate).HasColumnType("date");

            entity.Property(e => e.AssetAllo).HasColumnType("decimal");

            entity.Property(e => e.AssetAlloBlend).HasColumnType("decimal");

            entity.Property(e => e.Cusip)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.FscId)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.FundFamily)
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.InceptionDate).HasColumnType("date");

            entity.Property(e => e.M0ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M120BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M120InfoRatio).HasColumnType("decimal");

            entity.Property(e => e.M120ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M120RiskAdjustedReturn).HasColumnType("decimal");

            entity.Property(e => e.M120RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M120SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M120StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M120TrackingError).HasColumnType("decimal");

            entity.Property(e => e.M12AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M12BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M12InfoRatio).HasColumnType("decimal");

            entity.Property(e => e.M12ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M12RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M12SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M12StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M36AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36InfoRatio).HasColumnType("decimal");

            entity.Property(e => e.M36ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M36RiskAdjustedReturn).HasColumnType("decimal");

            entity.Property(e => e.M36RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M36SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M36StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M36TrackingError).HasColumnType("decimal");

            entity.Property(e => e.M3ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60AlphaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M60BattingAverage).HasColumnType("decimal");

            entity.Property(e => e.M60BetaPrimary).HasColumnType("decimal");

            entity.Property(e => e.M60CaptureRatioDown).HasColumnType("decimal");

            entity.Property(e => e.M60CaptureRatioUp).HasColumnType("decimal");

            entity.Property(e => e.M60InfoRatio).HasColumnType("decimal");

            entity.Property(e => e.M60ReturnValue).HasColumnType("decimal");

            entity.Property(e => e.M60RiskAdjustedReturn).HasColumnType("decimal");

            entity.Property(e => e.M60RSquaredPrimary).HasColumnType("decimal");

            entity.Property(e => e.M60SharpeRatio).HasColumnType("decimal");

            entity.Property(e => e.M60StandardDeviation).HasColumnType("decimal");

            entity.Property(e => e.M60TrackingError).HasColumnType("decimal");

            entity.Property(e => e.ManagerTenure).HasColumnType("decimal");

            entity.Property(e => e.MorningstarObjective)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(75)
                .HasColumnType("varchar");

            entity.Property(e => e.NetAssets).HasColumnType("decimal");

            entity.Property(e => e.NetAssetsReportDate).HasColumnType("date");

            entity.Property(e => e.NetExpenseRatio).HasColumnType("decimal");

            entity.Property(e => e.PctLargeBlend).HasColumnType("decimal");

            entity.Property(e => e.PctLargeGrowth).HasColumnType("decimal");

            entity.Property(e => e.PctLargeValue).HasColumnType("decimal");

            entity.Property(e => e.PctMidBlend).HasColumnType("decimal");

            entity.Property(e => e.PctMidGrowth).HasColumnType("decimal");

            entity.Property(e => e.PctMidValue).HasColumnType("decimal");

            entity.Property(e => e.PctSmallBlend).HasColumnType("decimal");

            entity.Property(e => e.PctSmallGrowth).HasColumnType("decimal");

            entity.Property(e => e.PctSmallValue).HasColumnType("decimal");

            entity.Property(e => e.PortfolioReportDate).HasColumnType("date");

            entity.Property(e => e.SinceInceptionReturn).HasColumnType("decimal");

            entity.Property(e => e.Strategy)
                .HasMaxLength(1500)
                .HasColumnType("varchar");

            entity.Property(e => e.Ticker)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.Top10HoldingWeighting).HasColumnType("decimal");

            entity.Property(e => e.TurnoverRatio).HasColumnType("decimal");

            entity.HasOne(d => d.Category).WithMany(p => p.FundDetail).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.Company).WithMany(p => p.FundDetail).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.DataFeed).WithMany(p => p.FundDetail).HasForeignKey(d => d.DataFeedId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PrimaryIndex).WithMany(p => p.FundDetail).HasForeignKey(d => d.PrimaryIndexId);

            entity.HasOne(d => d.ProspectusIndex).WithMany(p => p.FundDetailNavigation).HasForeignKey(d => d.ProspectusIndexId);

            entity.HasOne(d => d.SecondaryIndex).WithMany(p => p.FundDetail1).HasForeignKey(d => d.SecondaryIndexId);
         });


      }

   }
}
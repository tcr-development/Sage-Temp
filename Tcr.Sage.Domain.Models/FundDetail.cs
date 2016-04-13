using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class FundDetail {
      public FundDetail() {
         FundListFund = new HashSet<FundListFund>();
         ModelFreezerDetail = new HashSet<ModelFreezerDetail>();
         ProposalInvestment = new HashSet<ProposalInvestment>();
         ReviewFund = new HashSet<ReviewFund>();
         ReviewModelDetail = new HashSet<ReviewModelDetail>();
         ScoreWarehouseInvestmentScore = new HashSet<ScoreWarehouseInvestmentScore>();
      }

      public int Id { get; set; }
      public decimal? Actual12b1 { get; set; }
      public DateTime? AnnualReportDate { get; set; }
      public decimal? AssetAllo { get; set; }
      public decimal? AssetAlloBlend { get; set; }
      public int? CategoryId { get; set; }
      public int CompanyId { get; set; }
      public string Cusip { get; set; }
      public int DataFeedId { get; set; }
      public string FscId { get; set; }
      public string FundFamily { get; set; }
      public DateTime? InceptionDate { get; set; }
      public byte LegalTypeCd { get; set; }
      public byte? M0ReturnRank { get; set; }
      public decimal? M0ReturnValue { get; set; }
      public decimal? M120AlphaPrimary { get; set; }
      public byte? M120AlphaRank { get; set; }
      public decimal? M120BetaPrimary { get; set; }
      public byte? M120BetaRank { get; set; }
      public decimal? M120InfoRatio { get; set; }
      public byte? M120PerfRatingDesc { get; set; }
      public byte? M120RatingValue { get; set; }
      public byte? M120ReturnRank { get; set; }
      public decimal? M120ReturnValue { get; set; }
      public decimal? M120RiskAdjustedReturn { get; set; }
      public byte? M120RiskRatingDesc { get; set; }
      public decimal? M120RSquaredPrimary { get; set; }
      public byte? M120RSquaredRank { get; set; }
      public byte? M120SharpeRank { get; set; }
      public decimal? M120SharpeRatio { get; set; }
      public byte? M120StandardDevationRank { get; set; }
      public decimal? M120StandardDeviation { get; set; }
      public decimal? M120TrackingError { get; set; }
      public decimal? M12AlphaPrimary { get; set; }
      public decimal? M12BetaPrimary { get; set; }
      public decimal? M12InfoRatio { get; set; }
      public byte? M12ReturnRank { get; set; }
      public decimal? M12ReturnValue { get; set; }
      public decimal? M12RSquaredPrimary { get; set; }
      public decimal? M12SharpeRatio { get; set; }
      public decimal? M12StandardDeviation { get; set; }
      public byte? M255RatingValue { get; set; }
      public decimal? M36AlphaPrimary { get; set; }
      public byte? M36AlphaRank { get; set; }
      public decimal? M36BetaPrimary { get; set; }
      public byte? M36BetaRank { get; set; }
      public decimal? M36InfoRatio { get; set; }
      public byte? M36PerfRatingDesc { get; set; }
      public byte? M36RatingValue { get; set; }
      public byte? M36ReturnRank { get; set; }
      public decimal? M36ReturnValue { get; set; }
      public decimal? M36RiskAdjustedReturn { get; set; }
      public byte? M36RiskRatingDesc { get; set; }
      public decimal? M36RSquaredPrimary { get; set; }
      public byte? M36RSquaredRank { get; set; }
      public byte? M36SharpeRank { get; set; }
      public decimal? M36SharpeRatio { get; set; }
      public byte? M36StandardDevationRank { get; set; }
      public decimal? M36StandardDeviation { get; set; }
      public decimal? M36TrackingError { get; set; }
      public decimal? M3ReturnValue { get; set; }
      public decimal? M60AlphaPrimary { get; set; }
      public byte? M60AlphaRank { get; set; }
      public decimal? M60BattingAverage { get; set; }
      public decimal? M60BetaPrimary { get; set; }
      public byte? M60BetaRank { get; set; }
      public decimal? M60CaptureRatioDown { get; set; }
      public decimal? M60CaptureRatioUp { get; set; }
      public decimal? M60InfoRatio { get; set; }
      public byte? M60PerfRatingDesc { get; set; }
      public byte? M60RatingValue { get; set; }
      public byte? M60ReturnRank { get; set; }
      public decimal? M60ReturnValue { get; set; }
      public decimal? M60RiskAdjustedReturn { get; set; }
      public byte? M60RiskRatingDesc { get; set; }
      public decimal? M60RSquaredPrimary { get; set; }
      public byte? M60RSquaredRank { get; set; }
      public byte? M60SharpeRank { get; set; }
      public decimal? M60SharpeRatio { get; set; }
      public byte? M60StandardDevationRank { get; set; }
      public decimal? M60StandardDeviation { get; set; }
      public decimal? M60TrackingError { get; set; }
      public decimal? ManagerTenure { get; set; }
      public string MorningstarObjective { get; set; }
      public string Name { get; set; }
      public decimal? NetAssets { get; set; }
      public DateTime? NetAssetsReportDate { get; set; }
      public decimal? NetExpenseRatio { get; set; }
      public int? NumberOfHolding { get; set; }
      public decimal? PctLargeBlend { get; set; }
      public decimal? PctLargeGrowth { get; set; }
      public decimal? PctLargeValue { get; set; }
      public decimal? PctMidBlend { get; set; }
      public decimal? PctMidGrowth { get; set; }
      public decimal? PctMidValue { get; set; }
      public decimal? PctSmallBlend { get; set; }
      public decimal? PctSmallGrowth { get; set; }
      public decimal? PctSmallValue { get; set; }
      public DateTime? PortfolioReportDate { get; set; }
      public int? PrimaryIndexId { get; set; }
      public int? ProspectusIndexId { get; set; }
      public int? SecondaryIndexId { get; set; }
      public decimal? SinceInceptionReturn { get; set; }
      public string Strategy { get; set; }
      public string Ticker { get; set; }
      public decimal? Top10HoldingWeighting { get; set; }
      public decimal? TurnoverRatio { get; set; }

      public virtual ICollection<FundListFund> FundListFund { get; set; }
      public virtual ICollection<ModelFreezerDetail> ModelFreezerDetail { get; set; }
      public virtual ICollection<ProposalInvestment> ProposalInvestment { get; set; }
      public virtual ICollection<ReviewFund> ReviewFund { get; set; }
      public virtual ICollection<ReviewModelDetail> ReviewModelDetail { get; set; }
      public virtual ICollection<ScoreWarehouseInvestmentScore> ScoreWarehouseInvestmentScore { get; set; }
      public virtual CategoryDetail Category { get; set; }
      public virtual Company Company { get; set; }
      public virtual DataFeed DataFeed { get; set; }
      public virtual IndexDetail PrimaryIndex { get; set; }
      public virtual IndexDetail ProspectusIndex { get; set; }
      public virtual IndexDetail SecondaryIndex { get; set; }
   }
}

namespace Tcr.Sage.Domain.Models {
   public partial class ScoreWarehouseInvestmentScore {
      public int Id { get; set; }
      public string AssetAllo { get; set; }
      public string AssetAlloBlend { get; set; }
      public int? FundDetailId { get; set; }
      public bool HadNullsDuringTest { get; set; }
      public string InceptionDate { get; set; }
      public string M0ReturnRank { get; set; }
      public string M0ReturnValue { get; set; }
      public string M120AlphaPrimary { get; set; }
      public string M120AlphaRank { get; set; }
      public string M120BetaPrimary { get; set; }
      public string M120BetaRank { get; set; }
      public string M120PerfRatingDesc { get; set; }
      public string M120RatingValue { get; set; }
      public string M120ReturnRank { get; set; }
      public string M120ReturnValue { get; set; }
      public string M120RiskRatingDesc { get; set; }
      public string M120RSquaredPrimary { get; set; }
      public string M120RSquaredRank { get; set; }
      public string M120SharpeRank { get; set; }
      public string M120SharpeRatio { get; set; }
      public string M120StandardDeviation { get; set; }
      public string M12ReturnRank { get; set; }
      public string M12ReturnValue { get; set; }
      public string M12SharpeRatio { get; set; }
      public string M12StandardDeviation { get; set; }
      public string M255RatingValue { get; set; }
      public string M36AlphaPrimary { get; set; }
      public string M36AlphaRank { get; set; }
      public string M36BetaPrimary { get; set; }
      public string M36BetaRank { get; set; }
      public string M36PerfRatingDesc { get; set; }
      public string M36RatingValue { get; set; }
      public string M36ReturnRank { get; set; }
      public string M36ReturnValue { get; set; }
      public string M36RiskRatingDesc { get; set; }
      public string M36RSquaredPrimary { get; set; }
      public string M36RSquaredRank { get; set; }
      public string M36SharpeRank { get; set; }
      public string M36SharpeRatio { get; set; }
      public string M36StandardDeviation { get; set; }
      public string M60AlphaPrimary { get; set; }
      public string M60AlphaRank { get; set; }
      public string M60BattingAverage { get; set; }
      public string M60BetaPrimary { get; set; }
      public string M60BetaRank { get; set; }
      public string M60CaptureRatioDown { get; set; }
      public string M60CaptureRatioUp { get; set; }
      public string M60PerfRatingDesc { get; set; }
      public string M60RatingValue { get; set; }
      public string M60ReturnRank { get; set; }
      public string M60ReturnValue { get; set; }
      public string M60RiskRatingDesc { get; set; }
      public string M60RSquaredPrimary { get; set; }
      public string M60RSquaredRank { get; set; }
      public string M60SharpeRank { get; set; }
      public string M60SharpeRatio { get; set; }
      public string M60StandardDeviation { get; set; }
      public string ManagerTenure { get; set; }
      public int? ModelFreezerId { get; set; }
      public string Momentum { get; set; }
      public string NetAssets { get; set; }
      public string NetExpenseRatio { get; set; }
      public string NumberOfHolding { get; set; }
      public byte PassPct { get; set; }
      public byte ScoreRange { get; set; }
      public int ScoreWarehouseId { get; set; }
      public string Top10HoldingWeighting { get; set; }
      public decimal? TotalPoints { get; set; }
      public string TurnoverRatio { get; set; }

      public virtual FundDetail FundDetail { get; set; }
      public virtual ModelFreezer ModelFreezer { get; set; }
      public virtual ScoreWarehouse ScoreWarehouse { get; set; }
   }
}

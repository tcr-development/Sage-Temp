using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class CategoryDetail {
      public CategoryDetail() {
         FundDetail = new HashSet<FundDetail>();
      }

      public int Id { get; set; }
      public string CategoryId { get; set; }
      public int DataFeedId { get; set; }
      public decimal? ExpenseRatio { get; set; }
      public int? M0ReturnCatSize { get; set; }
      public decimal? M0ReturnValue { get; set; }
      public decimal? M120AlphaPrimary { get; set; }
      public decimal? M120BetaPrimary { get; set; }
      public int? M120ReturnCatSize { get; set; }
      public decimal? M120ReturnValue { get; set; }
      public decimal? M120RSquaredPrimary { get; set; }
      public decimal? M120SharpeRatio { get; set; }
      public decimal? M120StandardDeviation { get; set; }
      public decimal? M12AlphaPrimary { get; set; }
      public decimal? M12BetaPrimary { get; set; }
      public int? M12ReturnCatSize { get; set; }
      public decimal? M12ReturnValue { get; set; }
      public decimal? M12RSquaredPrimary { get; set; }
      public decimal? M36AlphaPrimary { get; set; }
      public decimal? M36BetaPrimary { get; set; }
      public int? M36ReturnCatSize { get; set; }
      public decimal? M36ReturnValue { get; set; }
      public decimal? M36RSquaredPrimary { get; set; }
      public decimal? M36SharpeRatio { get; set; }
      public decimal? M36StandardDeviation { get; set; }
      public decimal? M60AlphaPrimary { get; set; }
      public decimal? M60BattingAverage { get; set; }
      public decimal? M60BetaPrimary { get; set; }
      public decimal? M60CaptureRatioDown { get; set; }
      public decimal? M60CaptureRatioUp { get; set; }
      public int? M60ReturnCatSize { get; set; }
      public decimal? M60ReturnValue { get; set; }
      public decimal? M60RSquaredPrimary { get; set; }
      public decimal? M60SharpeRatio { get; set; }
      public decimal? M60StandardDeviation { get; set; }
      public decimal? ManagerTenure { get; set; }
      public string Name { get; set; }
      public decimal? NetAssets { get; set; }
      public decimal? NetExpenseRatio { get; set; }
      public decimal? TurnoverRatio { get; set; }

      public virtual ICollection<FundDetail> FundDetail { get; set; }
      public virtual DataFeed DataFeed { get; set; }
   }
}

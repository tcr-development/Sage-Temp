using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class IndexDetail {
      public IndexDetail() {
         FundDetail = new HashSet<FundDetail>();
         FundDetailNavigation = new HashSet<FundDetail>();
         FundDetail1 = new HashSet<FundDetail>();
      }

      public int Id { get; set; }
      public int DataFeedId { get; set; }
      public string IndexId { get; set; }
      public decimal? M0ReturnValue { get; set; }
      public decimal? M120ReturnValue { get; set; }
      public decimal? M120SharpeRatio { get; set; }
      public decimal? M120StandardDeviation { get; set; }
      public decimal? M12ReturnValue { get; set; }
      public decimal? M12SharpeRatio { get; set; }
      public decimal? M12StandardDeviation { get; set; }
      public decimal? M36ReturnValue { get; set; }
      public decimal? M36SharpeRatio { get; set; }
      public decimal? M36StandardDeviation { get; set; }
      public decimal? M3ReturnValue { get; set; }
      public decimal? M60ReturnValue { get; set; }
      public decimal? M60SharpeRatio { get; set; }
      public decimal? M60StandardDeviation { get; set; }
      public string Name { get; set; }

      public virtual ICollection<FundDetail> FundDetail { get; set; }
      public virtual ICollection<FundDetail> FundDetailNavigation { get; set; }
      public virtual ICollection<FundDetail> FundDetail1 { get; set; }
      public virtual DataFeed DataFeed { get; set; }
   }
}

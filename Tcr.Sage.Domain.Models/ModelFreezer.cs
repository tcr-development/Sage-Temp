using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ModelFreezer {
      public ModelFreezer() {
         ModelFreezerDetail = new HashSet<ModelFreezerDetail>();
         ProposalInvestment = new HashSet<ProposalInvestment>();
         ReviewModel = new HashSet<ReviewModel>();
         ScoreWarehouseInvestmentScore = new HashSet<ScoreWarehouseInvestmentScore>();
      }

      public int Id { get; set; }
      public decimal? M0ReturnValue { get; set; }
      public decimal? M120ReturnValue { get; set; }
      public decimal? M120SharpeRatio { get; set; }
      public decimal? M120StandardDeviation { get; set; }
      public decimal? M12ReturnValue { get; set; }
      public decimal? M36ReturnValue { get; set; }
      public decimal? M36SharpeRatio { get; set; }
      public decimal? M36StandardDeviation { get; set; }
      public decimal? M3ReturnValue { get; set; }
      public decimal? M60ReturnValue { get; set; }
      public decimal? M60SharpeRatio { get; set; }
      public decimal? M60StandardDeviation { get; set; }
      public string Name { get; set; }
      public int OwningItemId { get; set; }
      public byte OwningItemTypeCd { get; set; }
      public string RkModelId { get; set; }
      public string RkModelUserId { get; set; }

      public virtual ICollection<ModelFreezerDetail> ModelFreezerDetail { get; set; }
      public virtual ICollection<ProposalInvestment> ProposalInvestment { get; set; }
      public virtual ICollection<ReviewModel> ReviewModel { get; set; }
      public virtual ICollection<ScoreWarehouseInvestmentScore> ScoreWarehouseInvestmentScore { get; set; }
   }
}

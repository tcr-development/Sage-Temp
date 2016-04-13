namespace Tcr.Sage.Domain.Models {
   public partial class PlanInvestment {
      public int Id { get; set; }
      public decimal? Balance { get; set; }
      public string InvestmentId { get; set; }
      public bool IsModel { get; set; }
      public int PlanMasterId { get; set; }

      public virtual PlanMaster PlanMaster { get; set; }
   }
}

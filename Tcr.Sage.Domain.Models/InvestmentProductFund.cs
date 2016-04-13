namespace Tcr.Sage.Domain.Models {
   public partial class InvestmentProductFund {
      public int Id { get; set; }
      public decimal AlloPct { get; set; }
      public string Cusip { get; set; }
      public int InvestmentProductId { get; set; }

      public virtual InvestmentProduct InvestmentProduct { get; set; }
   }
}

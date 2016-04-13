namespace Tcr.Sage.Domain.Models {
   public partial class InvestmentProductReport {
      public int Id { get; set; }
      public int FileMasterId { get; set; }
      public int InvestmentProductId { get; set; }

      public virtual FileMaster FileMaster { get; set; }
      public virtual InvestmentProduct InvestmentProduct { get; set; }
   }
}

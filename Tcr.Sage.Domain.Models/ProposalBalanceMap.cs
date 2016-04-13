namespace Tcr.Sage.Domain.Models {
   public partial class ProposalBalanceMap {
      public int Id { get; set; }
      public int FromInvestmentId { get; set; }
      public decimal Percentage { get; set; }
      public int ProposalId { get; set; }
      public int ToInvestmentId { get; set; }

      public virtual ProposalInvestment FromInvestment { get; set; }
      public virtual Proposal Proposal { get; set; }
      public virtual ProposalInvestment ToInvestment { get; set; }
   }
}

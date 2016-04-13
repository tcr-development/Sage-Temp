using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class ProposalInvestment {
      public ProposalInvestment() {
         ProposalBalanceMap = new HashSet<ProposalBalanceMap>();
         ProposalBalanceMapNavigation = new HashSet<ProposalBalanceMap>();
      }

      public int Id { get; set; }
      public decimal? Balance { get; set; }
      public int? FundDetailId { get; set; }
      public bool IsCurrent { get; set; }
      public int? ModelFreezerId { get; set; }
      public int ProposalId { get; set; }

      public virtual ICollection<ProposalBalanceMap> ProposalBalanceMap { get; set; }
      public virtual ICollection<ProposalBalanceMap> ProposalBalanceMapNavigation { get; set; }
      public virtual FundDetail FundDetail { get; set; }
      public virtual ModelFreezer ModelFreezer { get; set; }
      public virtual Proposal Proposal { get; set; }
   }
}

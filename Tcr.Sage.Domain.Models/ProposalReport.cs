namespace Tcr.Sage.Domain.Models {
   public partial class ProposalReport {
      public int Id { get; set; }
      public int FileMasterId { get; set; }
      public int ProposalId { get; set; }

      public virtual FileMaster FileMaster { get; set; }
      public virtual Proposal Proposal { get; set; }
   }
}

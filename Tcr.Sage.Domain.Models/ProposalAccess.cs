namespace Tcr.Sage.Domain.Models {
   public partial class ProposalAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int ProposalId { get; set; }
      public int UserId { get; set; }

      public virtual Proposal Proposal { get; set; }
      public virtual User User { get; set; }
   }
}

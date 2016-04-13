namespace Tcr.Sage.Domain.Models {
   public partial class ProposalPlanContact {
      public int Id { get; set; }
      public byte ContactTypeCd { get; set; }
      public string EmailAddress { get; set; }
      public string Name { get; set; }
      public string Phone { get; set; }
      public int ProposalId { get; set; }

      public virtual Proposal Proposal { get; set; }
   }
}

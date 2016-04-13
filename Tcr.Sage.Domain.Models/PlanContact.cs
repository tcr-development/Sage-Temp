namespace Tcr.Sage.Domain.Models {
   public partial class PlanContact {
      public int Id { get; set; }
      public byte ContactTypeCd { get; set; }
      public string EmailAddress { get; set; }
      public string Name { get; set; }
      public byte? OrderNum { get; set; }
      public string Phone { get; set; }
      public int PlanMasterId { get; set; }

      public virtual PlanMaster PlanMaster { get; set; }
   }
}

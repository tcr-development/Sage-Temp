namespace Tcr.Sage.Domain.Models {
   public partial class ScoringToolAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int ScoringToolId { get; set; }
      public int UserId { get; set; }

      public virtual ScoringTool ScoringTool { get; set; }
      public virtual User User { get; set; }
   }
}

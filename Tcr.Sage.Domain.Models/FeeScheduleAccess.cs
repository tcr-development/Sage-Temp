namespace Tcr.Sage.Domain.Models {
   public partial class FeeScheduleAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int FeeScheduleId { get; set; }
      public int UserId { get; set; }

      public virtual FeeSchedule FeeSchedule { get; set; }
      public virtual User User { get; set; }
   }
}

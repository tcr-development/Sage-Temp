namespace Tcr.Sage.Domain.Models {
   public partial class FeeScheduleServiceProvider {
      public int Id { get; set; }
      public int FeeScheduleId { get; set; }
      public int ServiceProviderId { get; set; }

      public virtual FeeSchedule FeeSchedule { get; set; }
      public virtual ServiceProvider ServiceProvider { get; set; }
   }
}

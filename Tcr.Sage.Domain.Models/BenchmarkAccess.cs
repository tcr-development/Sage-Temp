namespace Tcr.Sage.Domain.Models {
   public partial class BenchmarkAccess {
      public int Id { get; set; }
      public byte AccessLevelCd { get; set; }
      public int BenchmarkId { get; set; }
      public int UserId { get; set; }

      public virtual Benchmark Benchmark { get; set; }
      public virtual User User { get; set; }
   }
}

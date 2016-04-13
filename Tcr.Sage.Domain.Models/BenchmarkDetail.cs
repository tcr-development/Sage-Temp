namespace Tcr.Sage.Domain.Models {
   public partial class BenchmarkDetail {
      public int Id { get; set; }
      public int BenchmarkId { get; set; }
      public string CatOrIndexId { get; set; }
      public decimal Percentage { get; set; }

      public virtual Benchmark Benchmark { get; set; }
   }
}

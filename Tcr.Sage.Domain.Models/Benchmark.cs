using System;
using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class Benchmark {
      public Benchmark() {
         BenchmarkAccess = new HashSet<BenchmarkAccess>();
         BenchmarkDetail = new HashSet<BenchmarkDetail>();
         InvestmentProduct = new HashSet<InvestmentProduct>();
      }

      public int Id { get; set; }
      public int CompanyId { get; set; }
      public DateTime CreatedDate { get; set; }
      public bool IsCategoryBased { get; set; }
      public DateTime LastModifyDate { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }

      public virtual ICollection<BenchmarkAccess> BenchmarkAccess { get; set; }
      public virtual ICollection<BenchmarkDetail> BenchmarkDetail { get; set; }
      public virtual ICollection<InvestmentProduct> InvestmentProduct { get; set; }
      public virtual Company Company { get; set; }
   }
}

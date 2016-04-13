using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class InvestmentProduct {
      public InvestmentProduct() {
         InvestmentProductFund = new HashSet<InvestmentProductFund>();
         InvestmentProductReport = new HashSet<InvestmentProductReport>();
      }

      public int Id { get; set; }
      public int? BenchmarkId { get; set; }
      public int CompanyId { get; set; }
      public string ModelId { get; set; }
      public string ModelUserId { get; set; }
      public string Name { get; set; }
      public byte RecordKeeperTypeCd { get; set; }

      public virtual ICollection<InvestmentProductFund> InvestmentProductFund { get; set; }
      public virtual ICollection<InvestmentProductReport> InvestmentProductReport { get; set; }
      public virtual Benchmark Benchmark { get; set; }
      public virtual Company Company { get; set; }
   }
}

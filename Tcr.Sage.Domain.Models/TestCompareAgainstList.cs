using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestCompareAgainstList {
      public TestCompareAgainstList() {
         TestColumn = new HashSet<TestColumn>();
         TestCompareAgainstListDetail = new HashSet<TestCompareAgainstListDetail>();
      }

      public byte Id { get; set; }
      public string Description { get; set; }

      public virtual ICollection<TestColumn> TestColumn { get; set; }
      public virtual ICollection<TestCompareAgainstListDetail> TestCompareAgainstListDetail { get; set; }
   }
}

using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestCompareOperatorList {
      public TestCompareOperatorList() {
         TestColumn = new HashSet<TestColumn>();
         TestCompareOperatorListDetail = new HashSet<TestCompareOperatorListDetail>();
      }

      public byte Id { get; set; }
      public string Description { get; set; }

      public virtual ICollection<TestColumn> TestColumn { get; set; }
      public virtual ICollection<TestCompareOperatorListDetail> TestCompareOperatorListDetail { get; set; }
   }
}

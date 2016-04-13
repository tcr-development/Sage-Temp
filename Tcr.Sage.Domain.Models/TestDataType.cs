using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestDataType {
      public TestDataType() {
         TestColumn = new HashSet<TestColumn>();
         TestDataTypeOption = new HashSet<TestDataTypeOption>();
      }

      public byte Id { get; set; }
      public string Description { get; set; }

      public virtual ICollection<TestColumn> TestColumn { get; set; }
      public virtual ICollection<TestDataTypeOption> TestDataTypeOption { get; set; }
   }
}

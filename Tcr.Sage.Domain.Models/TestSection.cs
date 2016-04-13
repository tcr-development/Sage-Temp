using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestSection {
      public TestSection() {
         TestColumn = new HashSet<TestColumn>();
      }

      public byte Id { get; set; }
      public string DisplayText { get; set; }
      public byte OrderNum { get; set; }
      public byte TestGroupId { get; set; }

      public virtual ICollection<TestColumn> TestColumn { get; set; }
      public virtual TestGroup TestGroup { get; set; }
   }
}

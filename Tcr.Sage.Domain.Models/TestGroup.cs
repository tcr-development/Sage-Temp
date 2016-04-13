using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class TestGroup {
      public TestGroup() {
         TestSection = new HashSet<TestSection>();
      }

      public byte Id { get; set; }
      public bool AllowForFilter { get; set; }
      public bool AllowForPassFail { get; set; }
      public bool AllowForPointBased { get; set; }
      public string DisplayText { get; set; }
      public byte OrderNum { get; set; }

      public virtual ICollection<TestSection> TestSection { get; set; }
   }
}

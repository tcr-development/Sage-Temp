using System.Collections.Generic;

namespace Tcr.Sage.Domain.Models {
   public partial class AspNetRoles {
      public AspNetRoles() {
         AspNetUserRoles = new HashSet<AspNetUserRoles>();
      }

      public int Id { get; set; }
      public string Name { get; set; }

      public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
   }
}

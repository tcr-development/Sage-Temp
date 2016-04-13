using Microsoft.AspNet.Identity.EntityFramework;

namespace Sage_Temp_UI.TcrIdentity {
   public class TcrIdentityDbContext : IdentityDbContext<TcrUser, TcrRole, int> {
       
   }

   public class TcrUser : IdentityUser<int> { }

   public class TcrRole : IdentityRole<int> { }
}
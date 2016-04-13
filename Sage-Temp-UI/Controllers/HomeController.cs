using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Tcr.Sage.Shared;

namespace Sage_Temp_UI.Controllers {
   [Authorize(Roles = UserRoles.SageUserRoleName)]
   public class HomeController : Controller {
      public IActionResult Index() {
         return View();
      }

      public IActionResult About() {
         ViewData["Message"] = "Your application description page.";

         return View();
      }

      public IActionResult Contact() {
         ViewData["Message"] = "Your contact page.";

         return View();
      }

      public IActionResult Error() {
         return View();
      }
   }
}

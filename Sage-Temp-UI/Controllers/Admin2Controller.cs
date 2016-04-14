using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Tcr.Sage.Shared;

namespace Sage_Temp_UI.Controllers {

   [Authorize(Roles = UserRoles.SysAdminRoleName)]
   public class Admin2Controller : Controller {
      public IActionResult Index() {
         return View();
      }

      public IActionResult Companies() {
         return View();
      }

      public IActionResult Edit(int id) {
         return View(id);
      }
   }
}
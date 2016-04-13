using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc.Rendering;

namespace Sage_Temp_UI.Utility {
   public static class UrlExtensions {
      private static IHttpContextAccessor _httpContextAccessor;

      public static void Configure(IHttpContextAccessor httpContextAccessor) {
         _httpContextAccessor = httpContextAccessor;
      }

      public static HtmlString BaseUrl() {
         return new HtmlString(_httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host + "/");

      }

   }
}
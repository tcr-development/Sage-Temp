using System;

namespace Tcr.Sage.Dal.SqlServer.Repository {
   public class BaseRepository : IDisposable {
      protected readonly SageContext DbContext;

      public BaseRepository(SageContext ctx) {
         DbContext = ctx;
      }
      public void Dispose() {
         DbContext?.Dispose();
      }
   }
}
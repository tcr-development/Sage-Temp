using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TradingPlatformAccessMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TradingPlatformAccess>(entity => {
            entity.HasIndex(e => e.UserId).HasName("Idx_TradingPlatformAccess_UserId");

            entity.HasOne(d => d.TradingPlatform).WithMany(p => p.TradingPlatformAccess).HasForeignKey(d => d.TradingPlatformId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.TradingPlatformAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
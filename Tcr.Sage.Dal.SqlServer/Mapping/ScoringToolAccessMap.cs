using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ScoringToolAccessMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ScoringToolAccess>(entity => {
            entity.HasIndex(e => e.UserId).HasName("Idx_ScoringToolAccess_UserId");

            entity.HasOne(d => d.ScoringTool).WithMany(p => p.ScoringToolAccess).HasForeignKey(d => d.ScoringToolId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.ScoringToolAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
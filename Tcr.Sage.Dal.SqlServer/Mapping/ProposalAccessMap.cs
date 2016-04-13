using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ProposalAccessMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ProposalAccess>(entity => {
            entity.HasIndex(e => e.ProposalId).HasName("idx_ProposalAccess");

            entity.HasIndex(e => e.UserId).HasName("idx_ProposalAccess_0");

            entity.HasOne(d => d.Proposal).WithMany(p => p.ProposalAccess).HasForeignKey(d => d.ProposalId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.ProposalAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
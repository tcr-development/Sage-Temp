using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ProposalReportMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ProposalReport>(entity => {
            entity.HasIndex(e => e.ProposalId).HasName("idx_ProposalReport");

            entity.HasOne(d => d.FileMaster).WithMany(p => p.ProposalReport).HasForeignKey(d => d.FileMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Proposal).WithMany(p => p.ProposalReport).HasForeignKey(d => d.ProposalId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
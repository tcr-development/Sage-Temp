using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ProposalBalanceMapMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ProposalBalanceMap>(entity => {
            entity.HasIndex(e => e.ProposalId).HasName("idx_ProposalBalanceMap");

            entity.Property(e => e.Percentage).HasColumnType("decimal");

            entity.HasOne(d => d.FromInvestment).WithMany(p => p.ProposalBalanceMap).HasForeignKey(d => d.FromInvestmentId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Proposal).WithMany(p => p.ProposalBalanceMap).HasForeignKey(d => d.ProposalId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ToInvestment).WithMany(p => p.ProposalBalanceMapNavigation).HasForeignKey(d => d.ToInvestmentId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
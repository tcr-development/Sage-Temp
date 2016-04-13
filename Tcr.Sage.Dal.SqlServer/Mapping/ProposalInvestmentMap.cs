using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ProposalInvestmentMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ProposalInvestment>(entity => {
            entity.HasIndex(e => e.ProposalId).HasName("idx_ProposalFund");

            entity.Property(e => e.Balance).HasColumnType("decimal");

            entity.HasOne(d => d.FundDetail).WithMany(p => p.ProposalInvestment).HasForeignKey(d => d.FundDetailId);

            entity.HasOne(d => d.ModelFreezer).WithMany(p => p.ProposalInvestment).HasForeignKey(d => d.ModelFreezerId);

            entity.HasOne(d => d.Proposal).WithMany(p => p.ProposalInvestment).HasForeignKey(d => d.ProposalId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
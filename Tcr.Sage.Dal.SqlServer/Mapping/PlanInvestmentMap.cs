using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class PlanInvestmentMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanInvestment>(entity => {
            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_PlanInvestment_PlanMasterId");

            entity.Property(e => e.Balance).HasColumnType("decimal");

            entity.Property(e => e.InvestmentId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanInvestment).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
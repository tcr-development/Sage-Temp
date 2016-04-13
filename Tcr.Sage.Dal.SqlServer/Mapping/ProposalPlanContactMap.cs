using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ProposalPlanContactMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ProposalPlanContact>(entity => {
            entity.HasIndex(e => e.ProposalId).HasName("idx_ProposalPlanContact");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Proposal).WithMany(p => p.ProposalPlanContact).HasForeignKey(d => d.ProposalId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ProposalMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<Proposal>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_Proposal_CompanyId");

            entity.HasIndex(e => e.DataFeedId).HasName("Idx_Proposal_DataFeedId");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.Archived).HasDefaultValue(false);

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.EIN)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.LastModifyDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.PlanName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnType("varchar");

            entity.Property(e => e.Zip)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.Proposal).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.CurrentFeeSchedule).WithMany(p => p.CurrentFeeScheduleProposals).HasForeignKey(d => d.CurrentFeeScheduleId);

            entity.HasOne(d => d.CurrentTradingPlatform).WithMany(p => p.Proposal).HasForeignKey(d => d.CurrentTradingPlatformId);

            entity.HasOne(d => d.DataFeed).WithMany(p => p.Proposal).HasForeignKey(d => d.DataFeedId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ProposedFeeSchedule).WithMany(p => p.ProposedFeeScheduleProposals).HasForeignKey(d => d.ProposedFeeScheduleId);

            entity.HasOne(d => d.ProposedTradingPlatform).WithMany(p => p.ProposalNavigation).HasForeignKey(d => d.ProposedTradingPlatformId);

            entity.HasOne(d => d.ScoreWarehouse).WithMany(p => p.Proposal).HasForeignKey(d => d.ScoreWarehouseId);
         });
      }
   }
}
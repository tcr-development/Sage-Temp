using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReportRequestMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReportRequest>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_ReportRequest_CompanyId");

            entity.HasIndex(e => e.FileMasterId).HasName("Idx_ReportRequest_FileMasterId");

            entity.HasIndex(e => e.ReportTemplateId).HasName("Idx_ReportRequest_ReportTemplateId");

            entity.Property(e => e.CompletedDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.FundDetailIds)
                .HasMaxLength(500)
                .HasColumnType("varchar");

            entity.Property(e => e.OutputFileName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar");

            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.StatusMessage)
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.ReportRequest).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.ReportRequest).HasForeignKey(d => d.PlanMasterId);
         });
      }
   }
}
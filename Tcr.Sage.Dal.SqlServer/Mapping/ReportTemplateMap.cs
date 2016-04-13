using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ReportTemplateMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ReportTemplate>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("idx_ReportTemplate");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.LastModifyDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.ReportTemplate).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FeeScheduleMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FeeSchedule>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_FeeSchedule_CompanyId");

            entity.Property(e => e.CreatedDate)
               .HasColumnType("datetime2(0)")
               .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.LastModifyDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.FeeSchedule).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
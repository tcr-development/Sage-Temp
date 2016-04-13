using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TradingPlatformMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TradingPlatform>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_TradingPlatform_CompanyId");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.LastModifyDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.TradingPlatform).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
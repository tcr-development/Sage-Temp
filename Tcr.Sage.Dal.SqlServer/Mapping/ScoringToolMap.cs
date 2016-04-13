using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ScoringToolMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ScoringTool>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_ScoringTool_CompanyId");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.LastModifyDate).HasColumnType("datetime2(0)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.ScoringTool).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ScoringToolTypeCdNavigation).WithMany(p => p.ScoringTool).HasForeignKey(d => d.ScoringToolTypeCd).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TradingPlatform).WithMany(p => p.ScoringTool).HasForeignKey(d => d.TradingPlatformId);
         });
      }
   }
}
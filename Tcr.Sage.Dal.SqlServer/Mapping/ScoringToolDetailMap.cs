using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ScoringToolDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ScoringToolDetail>(entity => {
            entity.HasIndex(e => e.ScoringToolId).HasName("Idx_ScoringToolDetail_ScoringToolId");

            entity.Property(e => e.LowerValue)
                .HasMaxLength(1000)
                .HasColumnType("varchar");

            entity.Property(e => e.UpperValue)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.Weighting).HasColumnType("decimal");

            entity.HasOne(d => d.ScoringTool).WithMany(p => p.ScoringToolDetail).HasForeignKey(d => d.ScoringToolId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestColumn).WithMany(p => p.ScoringToolDetail).HasForeignKey(d => d.TestColumnId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestCompareAgainstCdNavigation).WithMany(p => p.ScoringToolDetail).HasForeignKey(d => d.TestCompareAgainstCd).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestCompareOperatorCdNavigation).WithMany(p => p.ScoringToolDetail).HasForeignKey(d => d.TestCompareOperatorCd).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
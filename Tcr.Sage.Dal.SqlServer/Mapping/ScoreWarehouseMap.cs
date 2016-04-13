using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class ScoreWarehouseMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ScoreWarehouse>(entity => {
            entity.Property(e => e.CreatedDateUtc)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.ScoringToolName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.HasOne(d => d.OwningItemTypeCdNavigation).WithMany(p => p.ScoreWarehouse).HasForeignKey(d => d.OwningItemTypeCd).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ScoringToolTypeCdNavigation).WithMany(p => p.ScoreWarehouseNavigation).HasForeignKey(d => d.ScoringToolTypeCd).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
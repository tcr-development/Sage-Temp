using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TradingPlatformFundMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TradingPlatformFund>(entity => {
            entity.HasIndex(e => e.TradingPlatformId).HasName("Idx_TradingPlatformFund_TradingPlatformId");

            entity.Property(e => e.Cusip)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .HasColumnType("varchar");

            entity.Property(e => e.RevShareBps).HasColumnType("decimal");

            entity.Property(e => e.SubTaBps).HasColumnType("decimal");

            entity.Property(e => e.SubTaDollar).HasColumnType("decimal");

            entity.HasOne(d => d.TradingPlatform).WithMany(p => p.TradingPlatformFund).HasForeignKey(d => d.TradingPlatformId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
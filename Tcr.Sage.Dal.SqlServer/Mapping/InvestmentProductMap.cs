using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class InvestmentProductMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<InvestmentProduct>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_InvestmentProduct_CompanyId");

            entity.Property(e => e.ModelId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.ModelUserId)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Benchmark).WithMany(p => p.InvestmentProduct).HasForeignKey(d => d.BenchmarkId);

            entity.HasOne(d => d.Company).WithMany(p => p.InvestmentProduct).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
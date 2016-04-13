using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class InvestmentProductFundMap {

      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<InvestmentProductFund>(entity => {
            entity.Property(e => e.AlloPct).HasColumnType("decimal");

            entity.Property(e => e.Cusip)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.HasOne(d => d.InvestmentProduct).WithMany(p => p.InvestmentProductFund).HasForeignKey(d => d.InvestmentProductId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
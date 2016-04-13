using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class InvestmentProductReportMap {

      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<InvestmentProductReport>(entity => {
            entity.HasIndex(e => e.InvestmentProductId).HasName("Idx_InvestmentProductReport_InvProdId");

            entity.HasOne(d => d.FileMaster).WithMany(p => p.InvestmentProductReport).HasForeignKey(d => d.FileMasterId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.InvestmentProduct).WithMany(p => p.InvestmentProductReport).HasForeignKey(d => d.InvestmentProductId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class ModelFreezerDetailMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<ModelFreezerDetail>(entity => {
            entity.HasIndex(e => e.ModelFreezerId).HasName("IDX_ModelFreezerDetail_ModelFreezerId");

            entity.Property(e => e.AlloPct).HasColumnType("decimal");

            entity.HasOne(d => d.FundDetail).WithMany(p => p.ModelFreezerDetail).HasForeignKey(d => d.FundDetailId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.ModelFreezer).WithMany(p => p.ModelFreezerDetail).HasForeignKey(d => d.ModelFreezerId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
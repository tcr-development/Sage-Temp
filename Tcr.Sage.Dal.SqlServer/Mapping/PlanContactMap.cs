using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class PlanContactMap {
      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanContact>(entity => {
            entity.HasIndex(e => e.PlanMasterId).HasName("Idx_PlanContact_PlanId");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.HasOne(d => d.PlanMaster).WithMany(p => p.PlanContact).HasForeignKey(d => d.PlanMasterId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
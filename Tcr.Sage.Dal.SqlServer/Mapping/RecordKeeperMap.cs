using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class RecordKeeperMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<RecordKeeper>(entity => {
            entity.HasKey(e => e.CompanyId);

            entity.Property(e => e.CompanyId).ValueGeneratedNever();

            entity.Property(e => e.DataUrl)
                .HasMaxLength(200)
                .HasColumnType("varchar");

            entity.Property(e => e.Version)
                .HasMaxLength(25)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithOne(p => p.RecordKeeper).HasForeignKey<RecordKeeper>(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
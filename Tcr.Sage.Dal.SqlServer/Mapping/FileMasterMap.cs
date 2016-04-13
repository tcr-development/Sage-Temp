using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class FileMasterMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<FileMaster>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("idx_FileMaster");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("getutcdate()");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.FileMaster).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestColumnMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestColumn>(entity => {
            entity.Property(e => e.ColumnName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.DisplayText)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.FormatMask)
                .HasMaxLength(5)
                .HasColumnType("varchar");

            entity.HasOne(d => d.TestCompareAgainstList).WithMany(p => p.TestColumn).HasForeignKey(d => d.TestCompareAgainstListId);

            entity.HasOne(d => d.TestCompareOperatorList).WithMany(p => p.TestColumn).HasForeignKey(d => d.TestCompareOperatorListId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestDataType).WithMany(p => p.TestColumn).HasForeignKey(d => d.TestDataTypeId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.TestSection).WithMany(p => p.TestColumn).HasForeignKey(d => d.TestSectionId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
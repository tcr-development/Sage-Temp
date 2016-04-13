using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestDataTypeOptionMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestDataTypeOption>(entity => {
            entity.Property(e => e.DataValue)
                .HasMaxLength(2)
                .HasColumnType("varchar");

            entity.Property(e => e.DisplayText)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnType("varchar");

            entity.HasOne(d => d.TestDataType).WithMany(p => p.TestDataTypeOption).HasForeignKey(d => d.TestDataTypeId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
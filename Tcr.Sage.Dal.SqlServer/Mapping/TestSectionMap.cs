using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class TestSectionMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<TestSection>(entity => {
            entity.Property(e => e.DisplayText)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.HasOne(d => d.TestGroup).WithMany(p => p.TestSection).HasForeignKey(d => d.TestGroupId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
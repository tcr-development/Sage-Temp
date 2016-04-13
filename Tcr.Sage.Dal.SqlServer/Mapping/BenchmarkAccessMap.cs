using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class BenchmarkAccessMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<BenchmarkAccess>(entity => {
            // Primary Key
            entity.HasKey(t => t.Id);

            // Indexes
            entity.HasIndex(e => e.UserId).HasName("Idx_BenchmarkAccess_UserId");

            // Relationships
            entity.HasOne(d => d.Benchmark).WithMany(p => p.BenchmarkAccess).HasForeignKey(d => d.BenchmarkId).OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.User).WithMany(p => p.BenchmarkAccess).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
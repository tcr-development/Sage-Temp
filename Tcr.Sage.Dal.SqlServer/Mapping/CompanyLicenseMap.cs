using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {
   public class CompanyLicenseMap {
      public static void AddMap(ModelBuilder modelBuilder) {
         modelBuilder.Entity<CompanyLicense>(entity => {

            // Primary Key
            entity.HasKey(e => e.CompanyId);

            // Properties
            entity.Property(e => e.CompanyId).ValueGeneratedNever();

            // Relationships
            entity.HasOne(d => d.Company).WithOne(p => p.CompanyLicense).HasForeignKey<CompanyLicense>(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}
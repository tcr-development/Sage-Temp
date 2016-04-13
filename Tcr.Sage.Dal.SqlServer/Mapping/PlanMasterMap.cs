using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Tcr.Sage.Domain.Models;

namespace Tcr.Sage.Dal.SqlServer.Mapping {

   public class PlanMasterMap {

      public static void AddMap(ModelBuilder modelBuilder) {

         modelBuilder.Entity<PlanMaster>(entity => {
            entity.HasIndex(e => e.CompanyId).HasName("Idx_Plan_CompanyId");

            entity.HasIndex(e => new { e.CompanyId, e.PlanId }).HasName("UQ_PlanId_CompanyId").IsUnique();

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.BalanceAsOfDate).HasColumnType("date");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            entity.Property(e => e.ClientPlanId)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .HasColumnType("varchar");

            entity.Property(e => e.DataAsOfDate).HasColumnType("date");

            entity.Property(e => e.EmployerIdNumber)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.LoanBalance).HasColumnType("decimal");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnType("varchar");

            entity.Property(e => e.PlanId)
                .IsRequired()
                .HasMaxLength(12)
                .HasColumnType("varchar");

            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnType("varchar");

            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnType("varchar");

            entity.HasOne(d => d.Company).WithMany(p => p.PlanMaster).HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.Restrict);
         });
      }
   }
}